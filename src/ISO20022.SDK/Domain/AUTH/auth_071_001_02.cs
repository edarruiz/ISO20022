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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02", IsNullable=false)]
public partial class Document {
    
    private SecuritiesFinancingReportingTransactionReusedCollateralDataReportV02 sctiesFincgRptgTxReusdCollDataRptField;
    
    /// <remarks/>
    public SecuritiesFinancingReportingTransactionReusedCollateralDataReportV02 SctiesFincgRptgTxReusdCollDataRpt {
        get {
            return this.sctiesFincgRptgTxReusdCollDataRptField;
        }
        set {
            this.sctiesFincgRptgTxReusdCollDataRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class SecuritiesFinancingReportingTransactionReusedCollateralDataReportV02 {
    
    private TradeData36Choice tradDataField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public TradeData36Choice TradData {
        get {
            return this.tradDataField;
        }
        set {
            this.tradDataField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class TradeData36Choice {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DataSetActn", typeof(ReportPeriodActivity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Rpt", typeof(ReuseDataReport6Choice))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public enum ReportPeriodActivity1Code {
    
    /// <remarks/>
    NOTX,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReuseDataReport6Choice {
    
    private object itemField;
    
    private ItemChoiceType2 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollReuseUpd", typeof(ReuseDataReportCorrection14))]
    [System.Xml.Serialization.XmlElementAttribute("Crrctn", typeof(ReuseDataReportCorrection14))]
    [System.Xml.Serialization.XmlElementAttribute("Err", typeof(ReuseDataReportError5))]
    [System.Xml.Serialization.XmlElementAttribute("New", typeof(ReuseDataReportNew6))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemChoiceType2 ItemElementName {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReuseDataReportCorrection14 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData87 ctrPtyField;
    
    private CollateralType19[] collCmpntField;
    
    private System.DateTime evtDayField;
    
    private FundingSource3[] fndgSrcField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData87 CtrPty {
        get {
            return this.ctrPtyField;
        }
        set {
            this.ctrPtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollCmpnt")]
    public CollateralType19[] CollCmpnt {
        get {
            return this.collCmpntField;
        }
        set {
            this.collCmpntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime EvtDay {
        get {
            return this.evtDayField;
        }
        set {
            this.evtDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FndgSrc")]
    public FundingSource3[] FndgSrc {
        get {
            return this.fndgSrcField;
        }
        set {
            this.fndgSrcField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class CounterpartyData87 {
    
    private OrganisationIdentification15Choice rptSubmitgNttyField;
    
    private OrganisationIdentification15Choice rptgCtrPtyField;
    
    private OrganisationIdentification15Choice nttyRspnsblForRptField;
    
    /// <remarks/>
    public OrganisationIdentification15Choice RptSubmitgNtty {
        get {
            return this.rptSubmitgNttyField;
        }
        set {
            this.rptSubmitgNttyField = value;
        }
    }
    
    /// <remarks/>
    public OrganisationIdentification15Choice RptgCtrPty {
        get {
            return this.rptgCtrPtyField;
        }
        set {
            this.rptgCtrPtyField = value;
        }
    }
    
    /// <remarks/>
    public OrganisationIdentification15Choice NttyRspnsblForRpt {
        get {
            return this.nttyRspnsblForRptField;
        }
        set {
            this.nttyRspnsblForRptField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class OrganisationIdentification15Choice {
    
    private object itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("LEI", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Othr", typeof(OrganisationIdentification38))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public object Item {
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
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class OrganisationIdentification38 {
    
    private GenericIdentification175 idField;
    
    private string nmField;
    
    private string dmclField;
    
    /// <remarks/>
    public GenericIdentification175 Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
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
    
    /// <remarks/>
    public string Dmcl {
        get {
            return this.dmclField;
        }
        set {
            this.dmclField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class GenericIdentification175 {
    
    private string idField;
    
    private string schmeNmField;
    
    private string issrField;
    
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
    public string SchmeNm {
        get {
            return this.schmeNmField;
        }
        set {
            this.schmeNmField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReuseDataReportError5 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData87 ctrPtyField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData87 CtrPty {
        get {
            return this.ctrPtyField;
        }
        set {
            this.ctrPtyField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class AmountAndDirection53 {
    
    private ActiveOrHistoricCurrencyAndAmount amtField;
    
    private bool sgnField;
    
    private bool sgnFieldSpecified;
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount Amt {
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool SgnSpecified {
        get {
            return this.sgnFieldSpecified;
        }
        set {
            this.sgnFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class FundingSource3 {
    
    private FundingSourceType1Code tpField;
    
    private AmountAndDirection53 mktValField;
    
    /// <remarks/>
    public FundingSourceType1Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public AmountAndDirection53 MktVal {
        get {
            return this.mktValField;
        }
        set {
            this.mktValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public enum FundingSourceType1Code {
    
    /// <remarks/>
    SECL,
    
    /// <remarks/>
    FREE,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    BSHS,
    
    /// <remarks/>
    CSHS,
    
    /// <remarks/>
    REPO,
    
    /// <remarks/>
    UBOR,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReinvestedCashTypeAndAmount1 {
    
    private ReinvestmentType1Code tpField;
    
    private ActiveOrHistoricCurrencyAndAmount rinvstdCshAmtField;
    
    /// <remarks/>
    public ReinvestmentType1Code Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public ActiveOrHistoricCurrencyAndAmount RinvstdCshAmt {
        get {
            return this.rinvstdCshAmtField;
        }
        set {
            this.rinvstdCshAmtField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public enum ReinvestmentType1Code {
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    OCMP,
    
    /// <remarks/>
    MMFT,
    
    /// <remarks/>
    REPM,
    
    /// <remarks/>
    SDPU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class CashReuseData1 {
    
    private ReinvestedCashTypeAndAmount1[] rinvstdCshField;
    
    private decimal cshRinvstmtRateField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RinvstdCsh")]
    public ReinvestedCashTypeAndAmount1[] RinvstdCsh {
        get {
            return this.rinvstdCshField;
        }
        set {
            this.rinvstdCshField = value;
        }
    }
    
    /// <remarks/>
    public decimal CshRinvstmtRate {
        get {
            return this.cshRinvstmtRateField;
        }
        set {
            this.cshRinvstmtRateField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReuseValue1Choice {
    
    private ActiveOrHistoricCurrencyAndAmount itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Actl", typeof(ActiveOrHistoricCurrencyAndAmount))]
    [System.Xml.Serialization.XmlElementAttribute("Estmtd", typeof(ActiveOrHistoricCurrencyAndAmount))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public ActiveOrHistoricCurrencyAndAmount Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    Actl,
    
    /// <remarks/>
    Estmtd,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class SecurityReuseData1 {
    
    private string iSINField;
    
    private ReuseValue1Choice reuseValField;
    
    /// <remarks/>
    public string ISIN {
        get {
            return this.iSINField;
        }
        set {
            this.iSINField = value;
        }
    }
    
    /// <remarks/>
    public ReuseValue1Choice ReuseVal {
        get {
            return this.reuseValField;
        }
        set {
            this.reuseValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class CollateralType19 {
    
    private SecurityReuseData1[] sctyField;
    
    private CashReuseData1[] cshField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Scty")]
    public SecurityReuseData1[] Scty {
        get {
            return this.sctyField;
        }
        set {
            this.sctyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Csh")]
    public CashReuseData1[] Csh {
        get {
            return this.cshField;
        }
        set {
            this.cshField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02")]
public partial class ReuseDataReportNew6 {
    
    private string techRcrdIdField;
    
    private System.DateTime rptgDtTmField;
    
    private CounterpartyData87 ctrPtyField;
    
    private CollateralType19[] collCmpntField;
    
    private System.DateTime evtDayField;
    
    private FundingSource3[] fndgSrcField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public string TechRcrdId {
        get {
            return this.techRcrdIdField;
        }
        set {
            this.techRcrdIdField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime RptgDtTm {
        get {
            return this.rptgDtTmField;
        }
        set {
            this.rptgDtTmField = value;
        }
    }
    
    /// <remarks/>
    public CounterpartyData87 CtrPty {
        get {
            return this.ctrPtyField;
        }
        set {
            this.ctrPtyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CollCmpnt")]
    public CollateralType19[] CollCmpnt {
        get {
            return this.collCmpntField;
        }
        set {
            this.collCmpntField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime EvtDay {
        get {
            return this.evtDayField;
        }
        set {
            this.evtDayField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FndgSrc")]
    public FundingSource3[] FndgSrc {
        get {
            return this.fndgSrcField;
        }
        set {
            this.fndgSrcField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    AnyBIC,
    
    /// <remarks/>
    LEI,
    
    /// <remarks/>
    Othr,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:auth.071.001.02", IncludeInSchema=false)]
public enum ItemChoiceType2 {
    
    /// <remarks/>
    CollReuseUpd,
    
    /// <remarks/>
    Crrctn,
    
    /// <remarks/>
    Err,
    
    /// <remarks/>
    New,
}