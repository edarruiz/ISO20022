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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01", IsNullable=false)]
public partial class Document {
    
    private ForeignExchangeTradeCaptureReportRequestV01 fXTradCaptrRptReqField;
    
    /// <remarks/>
    public ForeignExchangeTradeCaptureReportRequestV01 FXTradCaptrRptReq {
        get {
            return this.fXTradCaptrRptReqField;
        }
        set {
            this.fXTradCaptrRptReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public partial class ForeignExchangeTradeCaptureReportRequestV01 {
    
    private MessageIdentification1 qryReqIdField;
    
    private QueryOrderStatus1Code qryOrdrStsField;
    
    private QueryDataType1Code qryTpField;
    
    private bool qryTpFieldSpecified;
    
    private string qryStartNbField;
    
    private bool qryByPrdField;
    
    private Period4 qryPrdField;
    
    private string qryTradIdField;
    
    private string qryEndIdField;
    
    private SupplementaryData1[] splmtryDataField;
    
    private string qryPgSzField;
    
    private string qryParamValField;
    
    /// <remarks/>
    public MessageIdentification1 QryReqId {
        get {
            return this.qryReqIdField;
        }
        set {
            this.qryReqIdField = value;
        }
    }
    
    /// <remarks/>
    public QueryOrderStatus1Code QryOrdrSts {
        get {
            return this.qryOrdrStsField;
        }
        set {
            this.qryOrdrStsField = value;
        }
    }
    
    /// <remarks/>
    public QueryDataType1Code QryTp {
        get {
            return this.qryTpField;
        }
        set {
            this.qryTpField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool QryTpSpecified {
        get {
            return this.qryTpFieldSpecified;
        }
        set {
            this.qryTpFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string QryStartNb {
        get {
            return this.qryStartNbField;
        }
        set {
            this.qryStartNbField = value;
        }
    }
    
    /// <remarks/>
    public bool QryByPrd {
        get {
            return this.qryByPrdField;
        }
        set {
            this.qryByPrdField = value;
        }
    }
    
    /// <remarks/>
    public Period4 QryPrd {
        get {
            return this.qryPrdField;
        }
        set {
            this.qryPrdField = value;
        }
    }
    
    /// <remarks/>
    public string QryTradId {
        get {
            return this.qryTradIdField;
        }
        set {
            this.qryTradIdField = value;
        }
    }
    
    /// <remarks/>
    public string QryEndId {
        get {
            return this.qryEndIdField;
        }
        set {
            this.qryEndIdField = value;
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
    
    /// <remarks/>
    public string QryPgSz {
        get {
            return this.qryPgSzField;
        }
        set {
            this.qryPgSzField = value;
        }
    }
    
    /// <remarks/>
    public string QryParamVal {
        get {
            return this.qryParamValField;
        }
        set {
            this.qryParamValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public partial class MessageIdentification1 {
    
    private string idField;
    
    private System.DateTime creDtTmField;
    
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
    public System.DateTime CreDtTm {
        get {
            return this.creDtTmField;
        }
        set {
            this.creDtTmField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public partial class DateAndDateTimeChoice {
    
    private System.DateTime itemField;
    
    private ItemChoiceType itemElementNameField;
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01", IncludeInSchema=false)]
public enum ItemChoiceType {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public partial class DateFormat18Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Dt", typeof(DateAndDateTimeChoice))]
    [System.Xml.Serialization.XmlElementAttribute("NotSpcfdDt", typeof(DateType8Code))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public enum DateType8Code {
    
    /// <remarks/>
    UKWN,
    
    /// <remarks/>
    ONGO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public partial class Period4 {
    
    private DateFormat18Choice startDtField;
    
    private DateFormat18Choice endDtField;
    
    /// <remarks/>
    public DateFormat18Choice StartDt {
        get {
            return this.startDtField;
        }
        set {
            this.startDtField = value;
        }
    }
    
    /// <remarks/>
    public DateFormat18Choice EndDt {
        get {
            return this.endDtField;
        }
        set {
            this.endDtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public enum QueryOrderStatus1Code {
    
    /// <remarks/>
    QUCO,
    
    /// <remarks/>
    QOFP,
    
    /// <remarks/>
    QFEO,
    
    /// <remarks/>
    QPEO,
    
    /// <remarks/>
    QUAO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01")]
public enum QueryDataType1Code {
    
    /// <remarks/>
    QFXT,
    
    /// <remarks/>
    QOTD,
}
