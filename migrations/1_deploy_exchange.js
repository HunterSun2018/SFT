const Migrations = artifacts.require("MySFT");
var erc3525 = artifacts.require("ERC3525");

module.exports = function (deployer) {

  //deployer.deploy(erc3525, "Test", "Test", 8);
  deployer.deploy(Migrations, "Test", "Test", 8);
};