using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace MySFT.sft.ContractDefinition
{


    public partial class SftDeployment : SftDeploymentBase
    {
        public SftDeployment() : base(BYTECODE) { }
        public SftDeployment(string byteCode) : base(byteCode) { }
    }

    public class SftDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "";
        public SftDeploymentBase() : base(BYTECODE) { }
        public SftDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("string", "name_", 1)]
        public virtual string Name { get; set; }
        [Parameter("string", "symbol_", 2)]
        public virtual string Symbol { get; set; }
        [Parameter("uint8", "decimals_", 3)]
        public virtual byte Decimals { get; set; }
    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId_", 1)]
        public virtual BigInteger Tokenid { get; set; }
        [Parameter("address", "operator_", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class Approve1Function : Approve1FunctionBase { }

    [Function("approve")]
    public class Approve1FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId_", 1)]
        public virtual BigInteger Tokenid { get; set; }
        [Parameter("address", "to_", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value_", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class BalanceOf1Function : BalanceOf1FunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOf1FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId_", 1)]
        public virtual BigInteger Tokenid { get; set; }
    }

    public partial class ContractURIFunction : ContractURIFunctionBase { }

    [Function("contractURI", "string")]
    public class ContractURIFunctionBase : FunctionMessage
    {

    }

    public partial class GetApprovedFunction : GetApprovedFunctionBase { }

    [Function("getApproved", "address")]
    public class GetApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class SafeTransferFrom1Function : SafeTransferFrom1FunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("bytes", "data", 4)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SlotOfFunction : SlotOfFunctionBase { }

    [Function("slotOf", "uint256")]
    public class SlotOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId_", 1)]
        public virtual BigInteger Tokenid { get; set; }
    }

    public partial class SlotURIFunction : SlotURIFunctionBase { }

    [Function("slotURI", "string")]
    public class SlotURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "slot_", 1)]
        public virtual BigInteger Slot { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

    }

    public partial class TokenByIndexFunction : TokenByIndexFunctionBase { }

    [Function("tokenByIndex", "uint256")]
    public class TokenByIndexFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "index", 1)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TokenOfOwnerByIndexFunction : TokenOfOwnerByIndexFunctionBase { }

    [Function("tokenOfOwnerByIndex", "uint256")]
    public class TokenOfOwnerByIndexFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "index", 2)]
        public virtual BigInteger Index { get; set; }
    }

    public partial class TokenURIFunction : TokenURIFunctionBase { }

    [Function("tokenURI", "string")]
    public class TokenURIFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "uint256")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "fromTokenId_", 1)]
        public virtual BigInteger Fromtokenid { get; set; }
        [Parameter("address", "to_", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value_", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferFrom1Function : TransferFrom1FunctionBase { }

    [Function("transferFrom")]
    public class TransferFrom1FunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferFrom2Function : TransferFrom2FunctionBase { }

    [Function("transferFrom")]
    public class TransferFrom2FunctionBase : FunctionMessage
    {
        [Parameter("uint256", "fromTokenId_", 1)]
        public virtual BigInteger Fromtokenid { get; set; }
        [Parameter("uint256", "toTokenId_", 2)]
        public virtual BigInteger Totokenid { get; set; }
        [Parameter("uint256", "value_", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class ValueDecimalsFunction : ValueDecimalsFunctionBase { }

    [Function("valueDecimals", "uint8")]
    public class ValueDecimalsFunctionBase : FunctionMessage
    {

    }

    public partial class MintFunction : MintFunctionBase { }

    [Function("mint")]
    public class MintFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "tokenId_", 1)]
        public virtual BigInteger Tokenid { get; set; }
        [Parameter("uint256", "slot_", 2)]
        public virtual BigInteger Slot { get; set; }
        [Parameter("uint256", "value_", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, true )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class ApprovalValueEventDTO : ApprovalValueEventDTOBase { }

    [Event("ApprovalValue")]
    public class ApprovalValueEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_tokenId", 1, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("address", "_operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("uint256", "_value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class SlotChangedEventDTO : SlotChangedEventDTOBase { }

    [Event("SlotChanged")]
    public class SlotChangedEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_tokenId", 1, true )]
        public virtual BigInteger TokenId { get; set; }
        [Parameter("uint256", "_oldSlot", 2, true )]
        public virtual BigInteger OldSlot { get; set; }
        [Parameter("uint256", "_newSlot", 3, true )]
        public virtual BigInteger NewSlot { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, true )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferValueEventDTO : TransferValueEventDTOBase { }

    [Event("TransferValue")]
    public class TransferValueEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "_fromTokenId", 1, true )]
        public virtual BigInteger FromTokenId { get; set; }
        [Parameter("uint256", "_toTokenId", 2, true )]
        public virtual BigInteger ToTokenId { get; set; }
        [Parameter("uint256", "_value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOf1OutputDTO : BalanceOf1OutputDTOBase { }

    [FunctionOutput]
    public class BalanceOf1OutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ContractURIOutputDTO : ContractURIOutputDTOBase { }

    [FunctionOutput]
    public class ContractURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetApprovedOutputDTO : GetApprovedOutputDTOBase { }

    [FunctionOutput]
    public class GetApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }







    public partial class SlotOfOutputDTO : SlotOfOutputDTOBase { }

    [FunctionOutput]
    public class SlotOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class SlotURIOutputDTO : SlotURIOutputDTOBase { }

    [FunctionOutput]
    public class SlotURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenByIndexOutputDTO : TokenByIndexOutputDTOBase { }

    [FunctionOutput]
    public class TokenByIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenOfOwnerByIndexOutputDTO : TokenOfOwnerByIndexOutputDTOBase { }

    [FunctionOutput]
    public class TokenOfOwnerByIndexOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenURIOutputDTO : TokenURIOutputDTOBase { }

    [FunctionOutput]
    public class TokenURIOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }







    public partial class ValueDecimalsOutputDTO : ValueDecimalsOutputDTOBase { }

    [FunctionOutput]
    public class ValueDecimalsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }


}
