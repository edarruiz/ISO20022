﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06", IsNullable=false)]
public partial class Document {
    
    private CollateralManagementCancellationRequestV06 collMgmtCxlReqField;
    
    /// <remarks/>
    public CollateralManagementCancellationRequestV06 CollMgmtCxlReq {
        get {
            return this.collMgmtCxlReqField;
        }
        set {
            this.collMgmtCxlReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralManagementCancellationRequestV06 {
    
    private Reference3Choice refField;
    
    private Obligation8 oblgtnField;
    
    private CollateralCancellationReason1 cxlRsnField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public Reference3Choice Ref {
        get {
            return this.refField;
        }
        set {
            this.refField = value;
        }
    }
    
    /// <remarks/>
    public Obligation8 Oblgtn {
        get {
            return this.oblgtnField;
        }
        set {
            this.oblgtnField = value;
        }
    }
    
    /// <remarks/>
    public CollateralCancellationReason1 CxlRsn {
        get {
            return this.cxlRsnField;
        }
        set {
            this.cxlRsnField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SplmtryData")]
    public SupplementaryData1[] SplmtryData {
        get {
            return this.splmtryDataField;
        }
        set {
            this.splmtryDataField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class Reference3Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ClntCollInstrId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("ClntCollTxId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CmonTxId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CollPrpslId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CollPrpslRspnId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CollSbstitnConfId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CollSbstitnReqId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("CollSbstitnRspnId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("DsptNtfctnId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("IntrstPmtReqId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("IntrstPmtRspnId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("IntrstPmtStmtId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("MrgnCallReqId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("MrgnCallRspnId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TrptyAgtSvcPrvdrCollInstrId", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("TrptyAgtSvcPrvdrCollTxId", typeof(string))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    ClntCollInstrId,
    
    /// <remarks/>
    ClntCollTxId,
    
    /// <remarks/>
    CmonTxId,
    
    /// <remarks/>
    CollPrpslId,
    
    /// <remarks/>
    CollPrpslRspnId,
    
    /// <remarks/>
    CollSbstitnConfId,
    
    /// <remarks/>
    CollSbstitnReqId,
    
    /// <remarks/>
    CollSbstitnRspnId,
    
    /// <remarks/>
    DsptNtfctnId,
    
    /// <remarks/>
    IntrstPmtReqId,
    
    /// <remarks/>
    IntrstPmtRspnId,
    
    /// <remarks/>
    IntrstPmtStmtId,
    
    /// <remarks/>
    MrgnCallReqId,
    
    /// <remarks/>
    MrgnCallRspnId,
    
    /// <remarks/>
    TrptyAgtSvcPrvdrCollInstrId,
    
    /// <remarks/>
    TrptyAgtSvcPrvdrCollTxId,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class SupplementaryData1 {
    
    private string plcAndNmField;
    
    private System.Xml.XmlElement envlpField;
    
    /// <remarks/>
    public string PlcAndNm {
        get {
            return this.plcAndNmField;
        }
        set {
            this.plcAndNmField = value;
        }
    }
    
    /// <remarks/>
    public System.Xml.XmlElement Envlp {
        get {
            return this.envlpField;
        }
        set {
            this.envlpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralCancellationType1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CollateralManagementCancellationReason1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum CollateralManagementCancellationReason1Code {
    
    /// <remarks/>
    PRER,
    
    /// <remarks/>
    PNSU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class GenericIdentification30 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralCancellationReason1 {
    
    private string addtlInfField;
    
    private CollateralCancellationType1Choice cxlRsnCdField;
    
    /// <remarks/>
    public string AddtlInf {
        get {
            return this.addtlInfField;
        }
        set {
            this.addtlInfField = value;
        }
    }
    
    /// <remarks/>
    public CollateralCancellationType1Choice CxlRsnCd {
        get {
            return this.cxlRsnCdField;
        }
        set {
            this.cxlRsnCdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class Date3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(DateType2Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum DateType2Code {
    
    /// <remarks/>
    OPEN,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class ClosingDate4Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Date3Choice))]
    [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(DateAndDateTime2Choice))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class DateAndDateTime2Choice {
    
    private System.DateTime itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(System.DateTime), DataType="date")]
    [System.Xml.Serialization.XmlElementAttribute("DtTm", typeof(System.DateTime))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public System.DateTime Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType1 ItemElementName {
        get {
            return this.itemElementNameField;
        }
        set {
            this.itemElementNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Dt,
    
    /// <remarks/>
    DtTm,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class ActiveOrHistoricCurrencyAndAmount {
    
    private string ccyField;
    
    private decimal valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Ccy {
        get {
            return this.ccyField;
        }
        set {
            this.ccyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    public decimal Value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralTransactionType1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CollateralTransactionType1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum CollateralTransactionType1Code {
    
    /// <remarks/>
    AADJ,
    
    /// <remarks/>
    CDTA,
    
    /// <remarks/>
    CADJ,
    
    /// <remarks/>
    DADJ,
    
    /// <remarks/>
    DBVT,
    
    /// <remarks/>
    INIT,
    
    /// <remarks/>
    MADJ,
    
    /// <remarks/>
    PADJ,
    
    /// <remarks/>
    RATA,
    
    /// <remarks/>
    TERM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class ExposureType21Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ExposureType11Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification30))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum ExposureType11Code {
    
    /// <remarks/>
    BFWD,
    
    /// <remarks/>
    PAYM,
    
    /// <remarks/>
    CBCO,
    
    /// <remarks/>
    COMM,
    
    /// <remarks/>
    CRDS,
    
    /// <remarks/>
    CRTL,
    
    /// <remarks/>
    CRSP,
    
    /// <remarks/>
    CCIR,
    
    /// <remarks/>
    CRPR,
    
    /// <remarks/>
    EQPT,
    
    /// <remarks/>
    EQUS,
    
    /// <remarks/>
    EXTD,
    
    /// <remarks/>
    EXPT,
    
    /// <remarks/>
    FIXI,
    
    /// <remarks/>
    FORX,
    
    /// <remarks/>
    FORW,
    
    /// <remarks/>
    FUTR,
    
    /// <remarks/>
    OPTN,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    OTCD,
    
    /// <remarks/>
    RVPO,
    
    /// <remarks/>
    SLOA,
    
    /// <remarks/>
    SBSC,
    
    /// <remarks/>
    SCRP,
    
    /// <remarks/>
    SLEB,
    
    /// <remarks/>
    SCIR,
    
    /// <remarks/>
    SCIE,
    
    /// <remarks/>
    SWPT,
    
    /// <remarks/>
    TBAS,
    
    /// <remarks/>
    TRCP,
    
    /// <remarks/>
    UDMS,
    
    /// <remarks/>
    CCPC,
    
    /// <remarks/>
    EQUI,
    
    /// <remarks/>
    TRBD,
    
    /// <remarks/>
    REPO,
    
    /// <remarks/>
    SHSL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class BlockChainAddressWallet5 {
    
    private string idField;
    
    private CollateralAccountIdentificationType3Choice tpField;
    
    private string nmField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccountIdentificationType3Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralAccountIdentificationType3Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification36))]
    [System.Xml.Serialization.XmlElementAttribute("Tp", typeof(CollateralAccountType1Code))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class GenericIdentification36 {
    
    private string idField;
    
    private string issrField;
    
    private string schmeNmField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public string Issr {
        get {
            return this.issrField;
        }
        set {
            this.issrField = value;
        }
    }
    
    /// <remarks/>
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum CollateralAccountType1Code {
    
    /// <remarks/>
    HOUS,
    
    /// <remarks/>
    CLIE,
    
    /// <remarks/>
    LIPR,
    
    /// <remarks/>
    MGIN,
    
    /// <remarks/>
    DFLT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class CollateralAccount3 {
    
    private string idField;
    
    private CollateralAccountIdentificationType3Choice tpField;
    
    private string nmField;
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccountIdentificationType3Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class PostalAddress2 {
    
    private string strtNmField;
    
    private string pstCdIdField;
    
    private string twnNmField;
    
    private string ctrySubDvsnField;
    
    private string ctryField;
    
    /// <remarks/>
    public string StrtNm {
        get {
            return this.strtNmField;
        }
        set {
            this.strtNmField = value;
        }
    }
    
    /// <remarks/>
    public string PstCdId {
        get {
            return this.pstCdIdField;
        }
        set {
            this.pstCdIdField = value;
        }
    }
    
    /// <remarks/>
    public string TwnNm {
        get {
            return this.twnNmField;
        }
        set {
            this.twnNmField = value;
        }
    }
    
    /// <remarks/>
    public string CtrySubDvsn {
        get {
            return this.ctrySubDvsnField;
        }
        set {
            this.ctrySubDvsnField = value;
        }
    }
    
    /// <remarks/>
    public string Ctry {
        get {
            return this.ctryField;
        }
        set {
            this.ctryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class NameAndAddress6 {
    
    private string nmField;
    
    private PostalAddress2 adrField;
    
    /// <remarks/>
    public string Nm {
        get {
            return this.nmField;
        }
        set {
            this.nmField = value;
        }
    }
    
    /// <remarks/>
    public PostalAddress2 Adr {
        get {
            return this.adrField;
        }
        set {
            this.adrField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class PartyIdentification178Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("NmAndAdr", typeof(NameAndAddress6))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification36))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public partial class Obligation8 {
    
    private PartyIdentification178Choice ptyAField;
    
    private PartyIdentification178Choice svcgPtyAField;
    
    private PartyIdentification178Choice ptyBField;
    
    private PartyIdentification178Choice svcgPtyBField;
    
    private CollateralAccount3 collAcctIdField;
    
    private BlockChainAddressWallet5 blckChainAdrOrWlltField;
    
    private ExposureType21Choice xpsrTpField;
    
    private CollateralTransactionType1Choice collTxTpField;
    
    private CollateralRole1Code collSdField;
    
    private bool collSdFieldSpecified;
    
    private ActiveOrHistoricCurrencyAndAmount xpsrAmtField;
    
    private DateAndDateTime2Choice valtnDtField;
    
    private ClosingDate4Choice clsgDtField;
    
    private DateAndDateTime2Choice reqdExctnDtField;
    
    private GenericIdentification30 sttlmPrcField;
    
    /// <remarks/>
    public PartyIdentification178Choice PtyA {
        get {
            return this.ptyAField;
        }
        set {
            this.ptyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification178Choice SvcgPtyA {
        get {
            return this.svcgPtyAField;
        }
        set {
            this.svcgPtyAField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification178Choice PtyB {
        get {
            return this.ptyBField;
        }
        set {
            this.ptyBField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification178Choice SvcgPtyB {
        get {
            return this.svcgPtyBField;
        }
        set {
            this.svcgPtyBField = value;
        }
    }
    
    /// <remarks/>
    public CollateralAccount3 CollAcctId {
        get {
            return this.collAcctIdField;
        }
        set {
            this.collAcctIdField = value;
        }
    }
    
    /// <remarks/>
    public BlockChainAddressWallet5 BlckChainAdrOrWllt {
        get {
            return this.blckChainAdrOrWlltField;
        }
        set {
            this.blckChainAdrOrWlltField = value;
        }
    }
    
    /// <remarks/>
    public ExposureType21Choice XpsrTp {
        get {
            return this.xpsrTpField;
        }
        set {
            this.xpsrTpField = value;
        }
    }
    
    /// <remarks/>
    public CollateralTransactionType1Choice CollTxTp {
        get {
            return this.collTxTpField;
        }
        set {
            this.collTxTpField = value;
        }
    }
    
    /// <remarks/>
    public CollateralRole1Code CollSd {
        get {
            return this.collSdField;
        }
        set {
            this.collSdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool CollSdSpecified {
        get {
            return this.collSdFieldSpecified;
        }
        set {
            this.collSdFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount XpsrAmt {
        get {
            return this.xpsrAmtField;
        }
        set {
            this.xpsrAmtField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTime2Choice ValtnDt {
        get {
            return this.valtnDtField;
        }
        set {
            this.valtnDtField = value;
        }
    }
    
    /// <remarks/>
    public ClosingDate4Choice ClsgDt {
        get {
            return this.clsgDtField;
        }
        set {
            this.clsgDtField = value;
        }
    }
    
    /// <remarks/>
    public DateAndDateTime2Choice ReqdExctnDt {
        get {
            return this.reqdExctnDtField;
        }
        set {
            this.reqdExctnDtField = value;
        }
    }
    
    /// <remarks/>
    public GenericIdentification30 SttlmPrc {
        get {
            return this.sttlmPrcField;
        }
        set {
            this.sttlmPrcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:colr.005.001.06")]
public enum CollateralRole1Code {
    
    /// <remarks/>
    GIVE,
    
    /// <remarks/>
    TAKE,
}
