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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01", IsNullable=false)]
public partial class Document {
    
    private CCPMemberObligationsReportV01 cCPMmbOblgtnsRptField;
    
    /// <remarks/>
    public CCPMemberObligationsReportV01 CCPMmbOblgtnsRpt {
        get {
            return this.cCPMmbOblgtnsRptField;
        }
        set {
            this.cCPMmbOblgtnsRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public partial class CCPMemberObligationsReportV01 {
    
    private SettlementAccount1[] sttlmAcctField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SttlmAcct")]
    public SettlementAccount1[] SttlmAcct {
        get {
            return this.sttlmAcctField;
        }
        set {
            this.sttlmAcctField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public partial class SettlementAccount1 {
    
    private GenericIdentification165 idField;
    
    private AmountAndDirection102 endOfDayInitlMrgnClldField;
    
    private AmountAndDirection102 endOfDayVartnMrgnClldField;
    
    private AmountAndDirection102 endOfDayDfltFndClldField;
    
    private AmountAndDirection102 endOfDaySttlmClldField;
    
    private AmountAndDirection102 endOfDayOthrClldField;
    
    private AmountAndDirection102 endOfDayLqdtyClldField;
    
    /// <remarks/>
    public GenericIdentification165 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDayInitlMrgnClld {
        get {
            return this.endOfDayInitlMrgnClldField;
        }
        set {
            this.endOfDayInitlMrgnClldField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDayVartnMrgnClld {
        get {
            return this.endOfDayVartnMrgnClldField;
        }
        set {
            this.endOfDayVartnMrgnClldField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDayDfltFndClld {
        get {
            return this.endOfDayDfltFndClldField;
        }
        set {
            this.endOfDayDfltFndClldField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDaySttlmClld {
        get {
            return this.endOfDaySttlmClldField;
        }
        set {
            this.endOfDaySttlmClldField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDayOthrClld {
        get {
            return this.endOfDayOthrClldField;
        }
        set {
            this.endOfDayOthrClldField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection102 EndOfDayLqdtyClld {
        get {
            return this.endOfDayLqdtyClldField;
        }
        set {
            this.endOfDayLqdtyClldField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public partial class GenericIdentification165 {
    
    private string idField;
    
    private string descField;
    
    private string issrField;
    
    private SchemeIdentificationType1Code schmeNmField;
    
    private bool schmeNmFieldSpecified;
    
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
    public string Desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
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
    public SchemeIdentificationType1Code SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SchmeNmSpecified {
        get {
            return this.schmeNmFieldSpecified;
        }
        set {
            this.schmeNmFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public enum SchemeIdentificationType1Code {
    
    /// <remarks/>
    MARG,
    
    /// <remarks/>
    COLL,
    
    /// <remarks/>
    POSI,
    
    /// <remarks/>
    CLIM,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public partial class ActiveCurrencyAndAmount {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.056.001.01")]
public partial class AmountAndDirection102 {
    
    private ActiveCurrencyAndAmount amtField;
    
    private bool sgnField;
    
    /// <remarks/>
    public ActiveCurrencyAndAmount Amt {
        get {
            return this.amtField;
        }
        set {
            this.amtField = value;
        }
    }
    
    /// <remarks/>
    public bool Sgn {
        get {
            return this.sgnField;
        }
        set {
            this.sgnField = value;
        }
    }
}