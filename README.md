A ERC-3535 SFT implementatiton using OpenZeppelin

## Save ABI
```
var fs = require('fs')
await fs.writeFile("build/sft.abi", JSON.stringify(sft.abi),  (err) => { })
```
##
```
Nethereum.Generator.Console generate from-abi -abi build/sft.abi -o web -ns MySFT
```
## Get Events
```
await sft.TransferValue().on('data', event => console.log(event))
or
await sft.getPastEvents('TransferValue', { fromBlock: 0, toBlock: 'latest' })
```