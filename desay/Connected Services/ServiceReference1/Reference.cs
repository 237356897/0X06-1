﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace desay.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Mes_WebServiceMainSoap")]
    public interface Mes_WebServiceMainSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fCanIGoTest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fCanIGoTest(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fCanIGoTest", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fCanIGoTestAsync(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendDataLink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fSendDataLink(string pchIPK, string pchModelK, string WN, string WSN, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendDataLink", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fSendDataLinkAsync(string pchIPK, string pchModelK, string WN, string WSN, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fSendData(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendData", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fSendDataAsync(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendAOIData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fSendAOIData(
                    int RecNo, 
                    string InspectionMachine, 
                    string InspectionProcess, 
                    string Program_Name, 
                    int BothSideCode, 
                    string SavedDate, 
                    int PcbNo, 
                    string CreateDate, 
                    string PersonRevisor, 
                    string ReviseEndDate, 
                    string TestResult, 
                    string ReviseResult, 
                    string Barcode, 
                    int ComponentTotal, 
                    int PinTotal, 
                    int ComponentBlockNo, 
                    int ComponentNo, 
                    string PartsName, 
                    int PartsTypeNo, 
                    int PartsVarNo, 
                    string PartsArticleNo, 
                    int PinNo, 
                    int FaultCode, 
                    int RevisedFaultId, 
                    string BatName, 
                    string ImageFilePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fSendAOIData", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fSendAOIDataAsync(
                    int RecNo, 
                    string InspectionMachine, 
                    string InspectionProcess, 
                    string Program_Name, 
                    int BothSideCode, 
                    string SavedDate, 
                    int PcbNo, 
                    string CreateDate, 
                    string PersonRevisor, 
                    string ReviseEndDate, 
                    string TestResult, 
                    string ReviseResult, 
                    string Barcode, 
                    int ComponentTotal, 
                    int PinTotal, 
                    int ComponentBlockNo, 
                    int ComponentNo, 
                    string PartsName, 
                    int PartsTypeNo, 
                    int PartsVarNo, 
                    string PartsArticleNo, 
                    int PinNo, 
                    int FaultCode, 
                    int RevisedFaultId, 
                    string BatName, 
                    string ImageFilePath);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBarCodeList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetBarCodeList(string pIp, string pPcName, string pUserCode, string pOrderCode, string pOrderType, string pBarType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBarCodeList", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetBarCodeListAsync(string pIp, string pPcName, string pUserCode, string pOrderCode, string pOrderType, string pBarType);
        
        // CODEGEN: 参数“fs”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpLoadFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        desay.ServiceReference1.UpLoadFileResponse UpLoadFile(desay.ServiceReference1.UpLoadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpLoadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<desay.ServiceReference1.UpLoadFileResponse> UpLoadFileAsync(desay.ServiceReference1.UpLoadFileRequest request);
        
        // CODEGEN: 参数“DownloadFileResult”需要其他方案信息，使用参数模式无法捕获这些信息。特定特性为“System.Xml.Serialization.XmlElementAttribute”。
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        desay.ServiceReference1.DownloadFileResponse DownloadFile(desay.ServiceReference1.DownloadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DownloadFile", ReplyAction="*")]
        System.Threading.Tasks.Task<desay.ServiceReference1.DownloadFileResponse> DownloadFileAsync(desay.ServiceReference1.DownloadFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fUploadIcBurnResult", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fUploadIcBurnResult(
                    string pchIPK, 
                    string UserCode, 
                    string pcName, 
                    string pOrderCode, 
                    string pOrderType, 
                    string pModelCode, 
                    string IcPartBarCode, 
                    string IcPartCode, 
                    string IcDateCode, 
                    string IcSupply, 
                    string programCode, 
                    string icId, 
                    string pCheckSum, 
                    string pBurnResult, 
                    string Amount, 
                    string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fUploadIcBurnResult", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fUploadIcBurnResultAsync(
                    string pchIPK, 
                    string UserCode, 
                    string pcName, 
                    string pOrderCode, 
                    string pOrderType, 
                    string pModelCode, 
                    string IcPartBarCode, 
                    string IcPartCode, 
                    string IcDateCode, 
                    string IcSupply, 
                    string programCode, 
                    string icId, 
                    string pCheckSum, 
                    string pBurnResult, 
                    string Amount, 
                    string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fOrderJx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fOrderJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fOrderJx", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fOrderJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fCheckICSoft", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fCheckICSoft(string OrderCode, string SPchICPartCode, string SPchSoftPartCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fCheckICSoft", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fCheckICSoftAsync(string OrderCode, string SPchICPartCode, string SPchSoftPartCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fPartLabelJx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fPartLabelJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fPartLabelJx", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fPartLabelJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fFixtureJx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fFixtureJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fFixtureJx", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fFixtureJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fPanelWNLink", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fPanelWNLink(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fPanelWNLink", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fPanelWNLinkAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fFixtureJx2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string fFixtureJx2(string pchIPK, string barCode1, string barCode2, string barCode3, string barCode4, string barCode5, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fFixtureJx2", ReplyAction="*")]
        System.Threading.Tasks.Task<string> fFixtureJx2Async(string pchIPK, string barCode1, string barCode2, string barCode3, string barCode4, string barCode5, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpLoadFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpLoadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] fs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string path;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string fileName;
        
        public UpLoadFileRequest() {
        }
        
        public UpLoadFileRequest(byte[] fs, string path, string fileName) {
            this.fs = fs;
            this.path = path;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpLoadFileResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpLoadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string UpLoadFileResult;
        
        public UpLoadFileResponse() {
        }
        
        public UpLoadFileResponse(string UpLoadFileResult) {
            this.UpLoadFileResult = UpLoadFileResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFile", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string strFilePath;
        
        public DownloadFileRequest() {
        }
        
        public DownloadFileRequest(string strFilePath) {
            this.strFilePath = strFilePath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DownloadFileResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DownloadFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] DownloadFileResult;
        
        public DownloadFileResponse() {
        }
        
        public DownloadFileResponse(byte[] DownloadFileResult) {
            this.DownloadFileResult = DownloadFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Mes_WebServiceMainSoapChannel : desay.ServiceReference1.Mes_WebServiceMainSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Mes_WebServiceMainSoapClient : System.ServiceModel.ClientBase<desay.ServiceReference1.Mes_WebServiceMainSoap>, desay.ServiceReference1.Mes_WebServiceMainSoap {
        
        public Mes_WebServiceMainSoapClient() {
        }
        
        public Mes_WebServiceMainSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Mes_WebServiceMainSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Mes_WebServiceMainSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Mes_WebServiceMainSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string fCanIGoTest(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fCanIGoTest(pchIPK, pchModelK, pchTestIdK, pchItemNameK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fCanIGoTestAsync(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fCanIGoTestAsync(pchIPK, pchModelK, pchTestIdK, pchItemNameK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public string fSendDataLink(string pchIPK, string pchModelK, string WN, string WSN, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fSendDataLink(pchIPK, pchModelK, WN, WSN, pchItemNameK, pchErrcdK, pchPfmdataK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fSendDataLinkAsync(string pchIPK, string pchModelK, string WN, string WSN, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fSendDataLinkAsync(pchIPK, pchModelK, WN, WSN, pchItemNameK, pchErrcdK, pchPfmdataK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public string fSendData(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fSendData(pchIPK, pchModelK, pchTestIdK, pchItemNameK, pchErrcdK, pchPfmdataK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fSendDataAsync(string pchIPK, string pchModelK, string pchTestIdK, string pchItemNameK, string pchErrcdK, string pchPfmdataK, string pchOperatorIDK, string pchStationIDK, string pOrderCode, string pOrderType, string programCode, string str1) {
            return base.Channel.fSendDataAsync(pchIPK, pchModelK, pchTestIdK, pchItemNameK, pchErrcdK, pchPfmdataK, pchOperatorIDK, pchStationIDK, pOrderCode, pOrderType, programCode, str1);
        }
        
        public string fSendAOIData(
                    int RecNo, 
                    string InspectionMachine, 
                    string InspectionProcess, 
                    string Program_Name, 
                    int BothSideCode, 
                    string SavedDate, 
                    int PcbNo, 
                    string CreateDate, 
                    string PersonRevisor, 
                    string ReviseEndDate, 
                    string TestResult, 
                    string ReviseResult, 
                    string Barcode, 
                    int ComponentTotal, 
                    int PinTotal, 
                    int ComponentBlockNo, 
                    int ComponentNo, 
                    string PartsName, 
                    int PartsTypeNo, 
                    int PartsVarNo, 
                    string PartsArticleNo, 
                    int PinNo, 
                    int FaultCode, 
                    int RevisedFaultId, 
                    string BatName, 
                    string ImageFilePath) {
            return base.Channel.fSendAOIData(RecNo, InspectionMachine, InspectionProcess, Program_Name, BothSideCode, SavedDate, PcbNo, CreateDate, PersonRevisor, ReviseEndDate, TestResult, ReviseResult, Barcode, ComponentTotal, PinTotal, ComponentBlockNo, ComponentNo, PartsName, PartsTypeNo, PartsVarNo, PartsArticleNo, PinNo, FaultCode, RevisedFaultId, BatName, ImageFilePath);
        }
        
        public System.Threading.Tasks.Task<string> fSendAOIDataAsync(
                    int RecNo, 
                    string InspectionMachine, 
                    string InspectionProcess, 
                    string Program_Name, 
                    int BothSideCode, 
                    string SavedDate, 
                    int PcbNo, 
                    string CreateDate, 
                    string PersonRevisor, 
                    string ReviseEndDate, 
                    string TestResult, 
                    string ReviseResult, 
                    string Barcode, 
                    int ComponentTotal, 
                    int PinTotal, 
                    int ComponentBlockNo, 
                    int ComponentNo, 
                    string PartsName, 
                    int PartsTypeNo, 
                    int PartsVarNo, 
                    string PartsArticleNo, 
                    int PinNo, 
                    int FaultCode, 
                    int RevisedFaultId, 
                    string BatName, 
                    string ImageFilePath) {
            return base.Channel.fSendAOIDataAsync(RecNo, InspectionMachine, InspectionProcess, Program_Name, BothSideCode, SavedDate, PcbNo, CreateDate, PersonRevisor, ReviseEndDate, TestResult, ReviseResult, Barcode, ComponentTotal, PinTotal, ComponentBlockNo, ComponentNo, PartsName, PartsTypeNo, PartsVarNo, PartsArticleNo, PinNo, FaultCode, RevisedFaultId, BatName, ImageFilePath);
        }
        
        public string GetBarCodeList(string pIp, string pPcName, string pUserCode, string pOrderCode, string pOrderType, string pBarType) {
            return base.Channel.GetBarCodeList(pIp, pPcName, pUserCode, pOrderCode, pOrderType, pBarType);
        }
        
        public System.Threading.Tasks.Task<string> GetBarCodeListAsync(string pIp, string pPcName, string pUserCode, string pOrderCode, string pOrderType, string pBarType) {
            return base.Channel.GetBarCodeListAsync(pIp, pPcName, pUserCode, pOrderCode, pOrderType, pBarType);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        desay.ServiceReference1.UpLoadFileResponse desay.ServiceReference1.Mes_WebServiceMainSoap.UpLoadFile(desay.ServiceReference1.UpLoadFileRequest request) {
            return base.Channel.UpLoadFile(request);
        }
        
        public string UpLoadFile(byte[] fs, string path, string fileName) {
            desay.ServiceReference1.UpLoadFileRequest inValue = new desay.ServiceReference1.UpLoadFileRequest();
            inValue.fs = fs;
            inValue.path = path;
            inValue.fileName = fileName;
            desay.ServiceReference1.UpLoadFileResponse retVal = ((desay.ServiceReference1.Mes_WebServiceMainSoap)(this)).UpLoadFile(inValue);
            return retVal.UpLoadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<desay.ServiceReference1.UpLoadFileResponse> desay.ServiceReference1.Mes_WebServiceMainSoap.UpLoadFileAsync(desay.ServiceReference1.UpLoadFileRequest request) {
            return base.Channel.UpLoadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<desay.ServiceReference1.UpLoadFileResponse> UpLoadFileAsync(byte[] fs, string path, string fileName) {
            desay.ServiceReference1.UpLoadFileRequest inValue = new desay.ServiceReference1.UpLoadFileRequest();
            inValue.fs = fs;
            inValue.path = path;
            inValue.fileName = fileName;
            return ((desay.ServiceReference1.Mes_WebServiceMainSoap)(this)).UpLoadFileAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        desay.ServiceReference1.DownloadFileResponse desay.ServiceReference1.Mes_WebServiceMainSoap.DownloadFile(desay.ServiceReference1.DownloadFileRequest request) {
            return base.Channel.DownloadFile(request);
        }
        
        public byte[] DownloadFile(string strFilePath) {
            desay.ServiceReference1.DownloadFileRequest inValue = new desay.ServiceReference1.DownloadFileRequest();
            inValue.strFilePath = strFilePath;
            desay.ServiceReference1.DownloadFileResponse retVal = ((desay.ServiceReference1.Mes_WebServiceMainSoap)(this)).DownloadFile(inValue);
            return retVal.DownloadFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<desay.ServiceReference1.DownloadFileResponse> desay.ServiceReference1.Mes_WebServiceMainSoap.DownloadFileAsync(desay.ServiceReference1.DownloadFileRequest request) {
            return base.Channel.DownloadFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<desay.ServiceReference1.DownloadFileResponse> DownloadFileAsync(string strFilePath) {
            desay.ServiceReference1.DownloadFileRequest inValue = new desay.ServiceReference1.DownloadFileRequest();
            inValue.strFilePath = strFilePath;
            return ((desay.ServiceReference1.Mes_WebServiceMainSoap)(this)).DownloadFileAsync(inValue);
        }
        
        public string fUploadIcBurnResult(
                    string pchIPK, 
                    string UserCode, 
                    string pcName, 
                    string pOrderCode, 
                    string pOrderType, 
                    string pModelCode, 
                    string IcPartBarCode, 
                    string IcPartCode, 
                    string IcDateCode, 
                    string IcSupply, 
                    string programCode, 
                    string icId, 
                    string pCheckSum, 
                    string pBurnResult, 
                    string Amount, 
                    string str1) {
            return base.Channel.fUploadIcBurnResult(pchIPK, UserCode, pcName, pOrderCode, pOrderType, pModelCode, IcPartBarCode, IcPartCode, IcDateCode, IcSupply, programCode, icId, pCheckSum, pBurnResult, Amount, str1);
        }
        
        public System.Threading.Tasks.Task<string> fUploadIcBurnResultAsync(
                    string pchIPK, 
                    string UserCode, 
                    string pcName, 
                    string pOrderCode, 
                    string pOrderType, 
                    string pModelCode, 
                    string IcPartBarCode, 
                    string IcPartCode, 
                    string IcDateCode, 
                    string IcSupply, 
                    string programCode, 
                    string icId, 
                    string pCheckSum, 
                    string pBurnResult, 
                    string Amount, 
                    string str1) {
            return base.Channel.fUploadIcBurnResultAsync(pchIPK, UserCode, pcName, pOrderCode, pOrderType, pModelCode, IcPartBarCode, IcPartCode, IcDateCode, IcSupply, programCode, icId, pCheckSum, pBurnResult, Amount, str1);
        }
        
        public string fOrderJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1) {
            return base.Channel.fOrderJx(pchIPK, barCode, pchItemNameK, UserCode, pcName, str1);
        }
        
        public System.Threading.Tasks.Task<string> fOrderJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1) {
            return base.Channel.fOrderJxAsync(pchIPK, barCode, pchItemNameK, UserCode, pcName, str1);
        }
        
        public string fCheckICSoft(string OrderCode, string SPchICPartCode, string SPchSoftPartCode) {
            return base.Channel.fCheckICSoft(OrderCode, SPchICPartCode, SPchSoftPartCode);
        }
        
        public System.Threading.Tasks.Task<string> fCheckICSoftAsync(string OrderCode, string SPchICPartCode, string SPchSoftPartCode) {
            return base.Channel.fCheckICSoftAsync(OrderCode, SPchICPartCode, SPchSoftPartCode);
        }
        
        public string fPartLabelJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1) {
            return base.Channel.fPartLabelJx(pchIPK, barCode, pchItemNameK, UserCode, pcName, str1);
        }
        
        public System.Threading.Tasks.Task<string> fPartLabelJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string str1) {
            return base.Channel.fPartLabelJxAsync(pchIPK, barCode, pchItemNameK, UserCode, pcName, str1);
        }
        
        public string fFixtureJx(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fFixtureJx(pchIPK, barCode, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fFixtureJxAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fFixtureJxAsync(pchIPK, barCode, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
        
        public string fPanelWNLink(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fPanelWNLink(pchIPK, barCode, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fPanelWNLinkAsync(string pchIPK, string barCode, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fPanelWNLinkAsync(pchIPK, barCode, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
        
        public string fFixtureJx2(string pchIPK, string barCode1, string barCode2, string barCode3, string barCode4, string barCode5, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fFixtureJx2(pchIPK, barCode1, barCode2, barCode3, barCode4, barCode5, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
        
        public System.Threading.Tasks.Task<string> fFixtureJx2Async(string pchIPK, string barCode1, string barCode2, string barCode3, string barCode4, string barCode5, string pchItemNameK, string UserCode, string pcName, string OrderCode, string str1) {
            return base.Channel.fFixtureJx2Async(pchIPK, barCode1, barCode2, barCode3, barCode4, barCode5, pchItemNameK, UserCode, pcName, OrderCode, str1);
        }
    }
}