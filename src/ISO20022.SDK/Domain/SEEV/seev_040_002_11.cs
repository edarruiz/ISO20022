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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11", IsNullable=false)]
public partial class Document {
    
    private CorporateActionInstructionCancellationRequest002V11 corpActnInstrCxlReqField;
    
    /// <remarks/>
    public CorporateActionInstructionCancellationRequest002V11 CorpActnInstrCxlReq {
        get {
            return this.corpActnInstrCxlReqField;
        }
        set {
            this.corpActnInstrCxlReqField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class CorporateActionInstructionCancellationRequest002V11 {
    
    private bool chngInstrIndField;
    
    private bool chngInstrIndFieldSpecified;
    
    private DocumentIdentification37 instrIdField;
    
    private CorporateActionGeneralInformation159 corpActnGnlInfField;
    
    private AccountIdentification62 acctDtlsField;
    
    private CorporateActionOption202 corpActnInstrField;
    
    private ProtectInstruction7 prtctInstrField;
    
    private SupplementaryData1[] splmtryDataField;
    
    /// <remarks/>
    public bool ChngInstrInd {
        get {
            return this.chngInstrIndField;
        }
        set {
            this.chngInstrIndField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ChngInstrIndSpecified {
        get {
            return this.chngInstrIndFieldSpecified;
        }
        set {
            this.chngInstrIndFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public DocumentIdentification37 InstrId {
        get {
            return this.instrIdField;
        }
        set {
            this.instrIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionGeneralInformation159 CorpActnGnlInf {
        get {
            return this.corpActnGnlInfField;
        }
        set {
            this.corpActnGnlInfField = value;
        }
    }
    
    /// <remarks/>
    public AccountIdentification62 AcctDtls {
        get {
            return this.acctDtlsField;
        }
        set {
            this.acctDtlsField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionOption202 CorpActnInstr {
        get {
            return this.corpActnInstrField;
        }
        set {
            this.corpActnInstrField = value;
        }
    }
    
    /// <remarks/>
    public ProtectInstruction7 PrtctInstr {
        get {
            return this.prtctInstrField;
        }
        set {
            this.prtctInstrField = value;
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class DocumentIdentification37 {
    
    private string idField;
    
    private ProcessingPosition10Choice lkgTpField;
    
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
    public ProcessingPosition10Choice LkgTp {
        get {
            return this.lkgTpField;
        }
        set {
            this.lkgTpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class ProcessingPosition10Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(ProcessingPosition3Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum ProcessingPosition3Code {
    
    /// <remarks/>
    AFTE,
    
    /// <remarks/>
    WITH,
    
    /// <remarks/>
    BEFO,
    
    /// <remarks/>
    INFO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class GenericIdentification47 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class ProtectInstruction7 {
    
    private ProtectTransactionType3Code txTpField;
    
    private string txIdField;
    
    private System.DateTime prtctDtField;
    
    private bool prtctDtFieldSpecified;
    
    /// <remarks/>
    public ProtectTransactionType3Code TxTp {
        get {
            return this.txTpField;
        }
        set {
            this.txTpField = value;
        }
    }
    
    /// <remarks/>
    public string TxId {
        get {
            return this.txIdField;
        }
        set {
            this.txIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime PrtctDt {
        get {
            return this.prtctDtField;
        }
        set {
            this.prtctDtField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool PrtctDtSpecified {
        get {
            return this.prtctDtFieldSpecified;
        }
        set {
            this.prtctDtFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum ProtectTransactionType3Code {
    
    /// <remarks/>
    PROT,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class FinancialInstrumentQuantity36Choice {
    
    private decimal itemField;
    
    private ItemChoiceType1 itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AmtsdVal", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("DgtlTknUnit", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("FaceAmt", typeof(decimal))]
    [System.Xml.Serialization.XmlElementAttribute("Unit", typeof(decimal))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
    public decimal Item {
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11", IncludeInSchema=false)]
public enum ItemChoiceType1 {
    
    /// <remarks/>
    AmtsdVal,
    
    /// <remarks/>
    DgtlTknUnit,
    
    /// <remarks/>
    FaceAmt,
    
    /// <remarks/>
    Unit,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class OriginalAndCurrentQuantities4 {
    
    private decimal faceAmtField;
    
    private decimal amtsdValField;
    
    /// <remarks/>
    public decimal FaceAmt {
        get {
            return this.faceAmtField;
        }
        set {
            this.faceAmtField = value;
        }
    }
    
    /// <remarks/>
    public decimal AmtsdVal {
        get {
            return this.amtsdValField;
        }
        set {
            this.amtsdValField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class Quantity55Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(Quantity1Code))]
    [System.Xml.Serialization.XmlElementAttribute("OrgnlAndCurFaceAmt", typeof(OriginalAndCurrentQuantities4))]
    [System.Xml.Serialization.XmlElementAttribute("Qty", typeof(FinancialInstrumentQuantity36Choice))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum Quantity1Code {
    
    /// <remarks/>
    QALL,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class CorporateActionOption43Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionOption16Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum CorporateActionOption16Code {
    
    /// <remarks/>
    ABST,
    
    /// <remarks/>
    BSPL,
    
    /// <remarks/>
    BUYA,
    
    /// <remarks/>
    CASE,
    
    /// <remarks/>
    CASH,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    CEXC,
    
    /// <remarks/>
    CONN,
    
    /// <remarks/>
    CONY,
    
    /// <remarks/>
    CTEN,
    
    /// <remarks/>
    EXER,
    
    /// <remarks/>
    LAPS,
    
    /// <remarks/>
    MKDW,
    
    /// <remarks/>
    MKUP,
    
    /// <remarks/>
    MPUT,
    
    /// <remarks/>
    NOAC,
    
    /// <remarks/>
    NOQU,
    
    /// <remarks/>
    OFFR,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    OVER,
    
    /// <remarks/>
    QINV,
    
    /// <remarks/>
    SECU,
    
    /// <remarks/>
    SLLE,
    
    /// <remarks/>
    TAXI,
    
    /// <remarks/>
    PRUN,
    
    /// <remarks/>
    BOBD,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class OptionNumber1Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(OptionNumber1Code))]
    [System.Xml.Serialization.XmlElementAttribute("Nb", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum OptionNumber1Code {
    
    /// <remarks/>
    UNSO,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class CorporateActionOption202 {
    
    private OptionNumber1Choice optnNbField;
    
    private CorporateActionOption43Choice optnTpField;
    
    private Quantity55Choice instdQtyField;
    
    /// <remarks/>
    public OptionNumber1Choice OptnNb {
        get {
            return this.optnNbField;
        }
        set {
            this.optnNbField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionOption43Choice OptnTp {
        get {
            return this.optnTpField;
        }
        set {
            this.optnTpField = value;
        }
    }
    
    /// <remarks/>
    public Quantity55Choice InstdQty {
        get {
            return this.instdQtyField;
        }
        set {
            this.instdQtyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class GenericIdentification89 {
    
    private GenericIdentification47 tpField;
    
    private string idField;
    
    /// <remarks/>
    public GenericIdentification47 Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class SafekeepingPlaceTypeAndIdentification1 {
    
    private SafekeepingPlace1Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace1Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
        }
    }
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum SafekeepingPlace1Code {
    
    /// <remarks/>
    CUST,
    
    /// <remarks/>
    ICSD,
    
    /// <remarks/>
    NCSD,
    
    /// <remarks/>
    SHHE,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class SafekeepingPlaceTypeAndText9 {
    
    private SafekeepingPlace2Code sfkpgPlcTpField;
    
    private string idField;
    
    /// <remarks/>
    public SafekeepingPlace2Code SfkpgPlcTp {
        get {
            return this.sfkpgPlcTpField;
        }
        set {
            this.sfkpgPlcTpField = value;
        }
    }
    
    /// <remarks/>
    public string Id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum SafekeepingPlace2Code {
    
    /// <remarks/>
    SHHE,
    
    /// <remarks/>
    ALLP,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class SafekeepingPlaceFormat34Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Ctry", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Id", typeof(SafekeepingPlaceTypeAndText9))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification89))]
    [System.Xml.Serialization.XmlElementAttribute("TpAndId", typeof(SafekeepingPlaceTypeAndIdentification1))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class GenericIdentification84 {
    
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class PartyIdentification136Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyBIC", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("PrtryId", typeof(GenericIdentification84))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class AccountIdentification62 {
    
    private string sfkpgAcctField;
    
    private string blckChainAdrOrWlltField;
    
    private PartyIdentification136Choice acctOwnrField;
    
    private SafekeepingPlaceFormat34Choice sfkpgPlcField;
    
    /// <remarks/>
    public string SfkpgAcct {
        get {
            return this.sfkpgAcctField;
        }
        set {
            this.sfkpgAcctField = value;
        }
    }
    
    /// <remarks/>
    public string BlckChainAdrOrWllt {
        get {
            return this.blckChainAdrOrWlltField;
        }
        set {
            this.blckChainAdrOrWlltField = value;
        }
    }
    
    /// <remarks/>
    public PartyIdentification136Choice AcctOwnr {
        get {
            return this.acctOwnrField;
        }
        set {
            this.acctOwnrField = value;
        }
    }
    
    /// <remarks/>
    public SafekeepingPlaceFormat34Choice SfkpgPlc {
        get {
            return this.sfkpgPlcField;
        }
        set {
            this.sfkpgPlcField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class IdentificationSource4Choice {
    
    private string itemField;
    
    private ItemChoiceType itemElementNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(string))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(string))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11", IncludeInSchema=false)]
public enum ItemChoiceType {
    
    /// <remarks/>
    Cd,
    
    /// <remarks/>
    Prtry,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class OtherIdentification2 {
    
    private string idField;
    
    private string sfxField;
    
    private IdentificationSource4Choice tpField;
    
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
    public string Sfx {
        get {
            return this.sfxField;
        }
        set {
            this.sfxField = value;
        }
    }
    
    /// <remarks/>
    public IdentificationSource4Choice Tp {
        get {
            return this.tpField;
        }
        set {
            this.tpField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class SecurityIdentification21 {
    
    private string iSINField;
    
    private OtherIdentification2[] othrIdField;
    
    private string descField;
    
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
    [System.Xml.Serialization.XmlElementAttribute("OthrId")]
    public OtherIdentification2[] OthrId {
        get {
            return this.othrIdField;
        }
        set {
            this.othrIdField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class CorporateActionEventType103Choice {
    
    private object itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Cd", typeof(CorporateActionEventType34Code))]
    [System.Xml.Serialization.XmlElementAttribute("Prtry", typeof(GenericIdentification47))]
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
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public enum CorporateActionEventType34Code {
    
    /// <remarks/>
    ACTV,
    
    /// <remarks/>
    ATTI,
    
    /// <remarks/>
    BRUP,
    
    /// <remarks/>
    DFLT,
    
    /// <remarks/>
    BONU,
    
    /// <remarks/>
    EXRI,
    
    /// <remarks/>
    CAPD,
    
    /// <remarks/>
    CAPG,
    
    /// <remarks/>
    CAPI,
    
    /// <remarks/>
    DRCA,
    
    /// <remarks/>
    DVCA,
    
    /// <remarks/>
    CHAN,
    
    /// <remarks/>
    COOP,
    
    /// <remarks/>
    CLSA,
    
    /// <remarks/>
    CONS,
    
    /// <remarks/>
    CONV,
    
    /// <remarks/>
    CREV,
    
    /// <remarks/>
    DECR,
    
    /// <remarks/>
    DETI,
    
    /// <remarks/>
    DSCL,
    
    /// <remarks/>
    DVOP,
    
    /// <remarks/>
    DRIP,
    
    /// <remarks/>
    DRAW,
    
    /// <remarks/>
    DTCH,
    
    /// <remarks/>
    EXOF,
    
    /// <remarks/>
    REDM,
    
    /// <remarks/>
    MCAL,
    
    /// <remarks/>
    INCR,
    
    /// <remarks/>
    PPMT,
    
    /// <remarks/>
    INTR,
    
    /// <remarks/>
    RHDI,
    
    /// <remarks/>
    LIQU,
    
    /// <remarks/>
    EXTM,
    
    /// <remarks/>
    MRGR,
    
    /// <remarks/>
    NOOF,
    
    /// <remarks/>
    CERT,
    
    /// <remarks/>
    ODLT,
    
    /// <remarks/>
    OTHR,
    
    /// <remarks/>
    PARI,
    
    /// <remarks/>
    PCAL,
    
    /// <remarks/>
    PRED,
    
    /// <remarks/>
    PINK,
    
    /// <remarks/>
    PLAC,
    
    /// <remarks/>
    PDEF,
    
    /// <remarks/>
    PRIO,
    
    /// <remarks/>
    BPUT,
    
    /// <remarks/>
    REDO,
    
    /// <remarks/>
    REMK,
    
    /// <remarks/>
    BIDS,
    
    /// <remarks/>
    SPLR,
    
    /// <remarks/>
    RHTS,
    
    /// <remarks/>
    DVSC,
    
    /// <remarks/>
    SHPR,
    
    /// <remarks/>
    SMAL,
    
    /// <remarks/>
    SOFF,
    
    /// <remarks/>
    DVSE,
    
    /// <remarks/>
    SPLF,
    
    /// <remarks/>
    TREC,
    
    /// <remarks/>
    TEND,
    
    /// <remarks/>
    DLST,
    
    /// <remarks/>
    SUSP,
    
    /// <remarks/>
    EXWA,
    
    /// <remarks/>
    WTRC,
    
    /// <remarks/>
    WRTH,
    
    /// <remarks/>
    ACCU,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:iso:std:iso:20022:tech:xsd:seev.040.002.11")]
public partial class CorporateActionGeneralInformation159 {
    
    private string corpActnEvtIdField;
    
    private string offclCorpActnEvtIdField;
    
    private CorporateActionEventType103Choice evtTpField;
    
    private SecurityIdentification21 finInstrmIdField;
    
    /// <remarks/>
    public string CorpActnEvtId {
        get {
            return this.corpActnEvtIdField;
        }
        set {
            this.corpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public string OffclCorpActnEvtId {
        get {
            return this.offclCorpActnEvtIdField;
        }
        set {
            this.offclCorpActnEvtIdField = value;
        }
    }
    
    /// <remarks/>
    public CorporateActionEventType103Choice EvtTp {
        get {
            return this.evtTpField;
        }
        set {
            this.evtTpField = value;
        }
    }
    
    /// <remarks/>
    public SecurityIdentification21 FinInstrmId {
        get {
            return this.finInstrmIdField;
        }
        set {
            this.finInstrmIdField = value;
        }
    }
}
