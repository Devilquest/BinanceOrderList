# Binance Order List
**This program let you get a list of all orders made on a [Binance](https://bit.ly/MartiBinance10) account and export them to an Excel spreadsheet.**

If you set the Api Key of a Binance account you can retrieve a list of all account orders; active, canceled, or filled. For a single trading pair (symbol) or a set of trading pairs. You can also limit the range by date, order status or order side.

## Dependences
- [Binance.Net](https://github.com/JKorf/Binance.Net)
- [ClosedXML](https://github.com/ClosedXML/ClosedXML)

## Configuration
Create a [Binance Api Key]((https://www.binance.com/en/support/faq/360002502072)) (Only read permissions are needed)
- Fill the `Api Key` and `Secret Key` text boxes with the generated Binance Api Key.
- Optionally you can save the credentials entered for later use by clicking the `Save User` button and giving it a name. *Note: Secret Key is stored as plain text, not encrypted, so be careful.*
- Set the symbol (trading pair) or a set of symbols (comma separated) you want to search. `E.g., BTCUSDT` or `ETHUSDT, DOGEEUR, ADABTC, LTCETH`
- **Options:**
  - **Start Date:** Set the start date of your search. Orders older than specified date will be ignored.
  - **End Date:** Set the end date of your search. Orders newer than specified date will be ignored.
  - **Order Status:** Choose the order status you want to filter. Set `All` to get all orders from all status types.
  - **Order Side:** Choose the order side you want to filter. Set `All` to get all orders from both sides, `buy` and `sell`.
 
## Usage
Once configured just click the `Search` button. If, for the given parameters, some data is found. A window with those data will appear. Then you can export the data to an Excel spreadsheet by clicking the `Export to Excel` button.

<br>

------------
## :heart:Donations
**Donations are always greatly appreciated. Thank you for your support!**

[![Bitcoin Badge](https://img.shields.io/badge/Bitcoin-89520e?style=flat&logo=bitcoin&logoColor=white)](#heartdonations)
[![Ethereum Badge](https://img.shields.io/badge/Ethereum-3C3C3D?style=flat&logo=ethereum&logoColor=white)](#heartdonations)
[![Dogecoin Badge](https://img.shields.io/badge/Dogecoin-C2A633?style=flat&logo=dogecoin&logoColor=white)](#heartdonations)
[![Litecoin Badge](https://img.shields.io/badge/Litecoin-A6A9AA?style=flat&logo=litecoin&logoColor=white)](#heartdonations)

**BTC:** 1M5yLyLWmELQo2e6chBZ35RkhcTUon66u5

**ETH:** 0xa6d337a733cbce6aa2f0aa72f83beced3464ee86

**DOGE:** DNm19soXsPHHSpqsMUiy75kciw9sBrqeZ8

**LTC:** MKiegbfCssBEJdtNm3tGcnAhBF2xvcQ6d1
