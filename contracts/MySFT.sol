// contracts/MySFT.sol
// SPDX-License-Identifier: MIT
pragma solidity ^0.8.0;

import "./ERC3525.sol";

contract MySFT is ERC3525 {
    
    constructor( string memory name_, string memory symbol_, uint8 decimals_) ERC3525(name_, symbol_, decimals_) {}

    function mint(uint256 tokenId_, uint256 slot_, uint256 value_) public payable {
        ERC3525._mintValue(_msgSender(), tokenId_, slot_, value_);
    }
}