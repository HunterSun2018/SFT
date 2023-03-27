//SPDX-License-Identifier: CC0-1.0
pragma solidity ^0.8.0;

// Import the ERC721 and ERC20 token interfaces
import "@openzeppelin/contracts/token/ERC721/IERC721.sol";
import "@openzeppelin/contracts/token/ERC20/IERC20.sol";

interface ITokenExchange {
    
}

contract TokenExchange {
    // Define the ERC721 and ERC20 token contracts
    IERC721 public nftContract;
    IERC20 public tokenContract;

    // Define the exchange rate of ERC20 tokens to ERC721 tokens
    uint256 public exchangeRate;

    // Define an event for logging token exchanges    
    event ExchangeTokens(address indexed owner, uint256 amount, uint256 tokenId);    

    // Constructor function to set the exchange rate and token contracts
    constructor(IERC721 _nftContract, IERC20 _tokenContract, uint256 _exchangeRate) {
        nftContract = _nftContract;
        tokenContract = _tokenContract;
        exchangeRate = _exchangeRate;
    }

    // Function to exchange ERC20 tokens for an ERC721 token
    function exchangeTokens(uint256 _tokenId, uint256 _amount) public {
        // Ensure that the sender has approved the exchange of their ERC721 token
        require(nftContract.getApproved(_tokenId) == address(this), "Exchange contract not approved to transfer token");

        // Ensure that the sender has enough ERC20 tokens to exchange
        require(tokenContract.balanceOf(msg.sender) >= _amount, "Insufficient token balance");

        // Calculate the required amount of ERC20 tokens for the exchange
        uint256 requiredTokens = _amount * exchangeRate;

        // Ensure that the exchange rate is fair for the sender
        require(requiredTokens <= tokenContract.balanceOf(address(this)), "Exchange contract does not have enough tokens");

        // Transfer the ERC20 tokens to the exchange contract
        tokenContract.transferFrom(msg.sender, address(this), _amount);

        // Transfer the ERC721 token to the sender
        nftContract.transferFrom(address(this), msg.sender, _tokenId);

        // Log the token exchange
        emit ExchangeTokens(msg.sender, _amount, _tokenId);
    }
}

