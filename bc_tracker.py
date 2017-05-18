#!/usr/bin/env python

import pycurl
from io import BytesIO
import json

address1 = "12t9YDPgwueZ9NyMgw519p7AA8isjr6SMw"
address2 = "115p7UMMngoj1pMvkpHijcRdfJNXj6LrLn"
address3 = "13AM4VW2dhxYgXeQepoHkHSQuy6NgaEb94"
address_list = address1+'|'+address2+'|'+address3
bchain_url = "https://blockchain.info/q/"
bchain_grba = bchain_url+"getreceivedbyaddress/"+address_list
exch_rates = "https://blockchain.info/ticker"

def getWebData(url):
	buffer = BytesIO()
	c = pycurl.Curl()
	c.setopt(c.URL, url)
	c.setopt(c.WRITEDATA, buffer)
	c.perform()
	c.close()
	return buffer
	
def getBC(url):
	data = getWebData(url)
	body = data.getvalue()
	pricing = int(body.decode('iso-8859-1'))/100000000
	return pricing

def getExchRates(url):
	body = getWebData(url)
	dictionary = json.loads(body.getvalue())
	return dictionary
	
def printConvRates(bc, conv):
	for c in conv:
		print(c + " : "  + str(round((bc * conv[c]['last']), 2)))


value = getBC(bchain_grba)
print("\n\nBitcoin paid:  " + str(round(value, 2)))
print("----------------------------------------")
rates = getExchRates(exch_rates)
printConvRates(value, rates)
