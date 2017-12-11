using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SDSComApp.Models
{   
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EcotoxicologicalInformation
    {
        private EcotoxicityTestResults ecotoxicityTestResultsField;

        private Phrase[] otherEcotoxInfoFishField;

        private Phrase[] otherEcotoxInfoAlgaePlantField;

        private Phrase[] otherEcotoxInfoCrustaceansField;

        private Phrase[] otherEcotoxInfoImpactOnSewageTreatmentField;

        private Phrase[] ecotoxicologyOtherDataField;

        private Phrase[] ecotoxicologyOverallEvaluationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public EcotoxicityTestResults EcotoxicityTestResults
        {
            get
            {
                return this.ecotoxicityTestResultsField;
            }
            set
            {
                this.ecotoxicityTestResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherEcotoxInfoFish", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherEcotoxInfoFish
        {
            get
            {
                return this.otherEcotoxInfoFishField;
            }
            set
            {
                this.otherEcotoxInfoFishField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherEcotoxInfoAlgaePlant", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherEcotoxInfoAlgaePlant
        {
            get
            {
                return this.otherEcotoxInfoAlgaePlantField;
            }
            set
            {
                this.otherEcotoxInfoAlgaePlantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherEcotoxInfoCrustaceans", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherEcotoxInfoCrustaceans
        {
            get
            {
                return this.otherEcotoxInfoCrustaceansField;
            }
            set
            {
                this.otherEcotoxInfoCrustaceansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherEcotoxInfoImpactOnSewageTreatment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherEcotoxInfoImpactOnSewageTreatment
        {
            get
            {
                return this.otherEcotoxInfoImpactOnSewageTreatmentField;
            }
            set
            {
                this.otherEcotoxInfoImpactOnSewageTreatmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EcotoxicologyOtherData", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EcotoxicologyOtherData
        {
            get
            {
                return this.ecotoxicologyOtherDataField;
            }
            set
            {
                this.ecotoxicologyOtherDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EcotoxicologyOverallEvaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] EcotoxicologyOverallEvaluation
        {
            get
            {
                return this.ecotoxicologyOverallEvaluationField;
            }
            set
            {
                this.ecotoxicologyOverallEvaluationField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EcotoxicityTestResults
    {

        private Ecotoxicity[] fishToxicityField;

        private Ecotoxicity[] crustaceanToxicityField;

        private Ecotoxicity[] algaeToxicityField;

        private Ecotoxicity[] bacteriaToxicityField;

        private Ecotoxicity[] birdToxicityField;

        private Ecotoxicity[] insectToxicityField;

        private Ecotoxicity[] earthwormToxicityField;

        private Ecotoxicity[] soilMicroorganismsToxicityField;

        private Ecotoxicity[] sedimentLivingOrganismsToxicityField;

        private Ecotoxicity[] plantToxicityField;

        private ImpactOnSewageTreatment[] impactOnSewageTreatmentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FishToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] FishToxicity
        {
            get
            {
                return this.fishToxicityField;
            }
            set
            {
                this.fishToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CrustaceanToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] CrustaceanToxicity
        {
            get
            {
                return this.crustaceanToxicityField;
            }
            set
            {
                this.crustaceanToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlgaeToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] AlgaeToxicity
        {
            get
            {
                return this.algaeToxicityField;
            }
            set
            {
                this.algaeToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BacteriaToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] BacteriaToxicity
        {
            get
            {
                return this.bacteriaToxicityField;
            }
            set
            {
                this.bacteriaToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BirdToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] BirdToxicity
        {
            get
            {
                return this.birdToxicityField;
            }
            set
            {
                this.birdToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InsectToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] InsectToxicity
        {
            get
            {
                return this.insectToxicityField;
            }
            set
            {
                this.insectToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EarthwormToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] EarthwormToxicity
        {
            get
            {
                return this.earthwormToxicityField;
            }
            set
            {
                this.earthwormToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SoilMicroorganismsToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] SoilMicroorganismsToxicity
        {
            get
            {
                return this.soilMicroorganismsToxicityField;
            }
            set
            {
                this.soilMicroorganismsToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SedimentLivingOrganismsToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] SedimentLivingOrganismsToxicity
        {
            get
            {
                return this.sedimentLivingOrganismsToxicityField;
            }
            set
            {
                this.sedimentLivingOrganismsToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PlantToxicity", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity[] PlantToxicity
        {
            get
            {
                return this.plantToxicityField;
            }
            set
            {
                this.plantToxicityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ImpactOnSewageTreatment", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ImpactOnSewageTreatment[] ImpactOnSewageTreatment
        {
            get
            {
                return this.impactOnSewageTreatmentField;
            }
            set
            {
                this.impactOnSewageTreatmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ImpactOnSewageTreatment
    {

        private Ecotoxicity valueField;

        private Phrase inoculumField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Ecotoxicity Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Inoculum
        {
            get
            {
                return this.inoculumField;
            }
            set
            {
                this.inoculumField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class PersistenceDegradability
    {

        private Phrase[] persistenceDegradabilityDescriptionField;

        private Phrase[] degradationHalfLifeField;

        private DegradationAndEliminationResults degradationAndEliminationResultsField;

        private Phrase[] degradationInSewagePlantDescriptionField;

        private FurtherEcologicalData[] chemicalOxygenDemandField;

        private FurtherEcologicalData[] biochemicalOxygenDemandField;

        private Bod5CodRatio[] bod5CodRatioField;

        private FurtherEcologicalData[] theoreticalOxygenDemandField;

        private Phrase[] persistenceDegradabilityAdditionalInfoField;

        private Phrase[] persistenceDegradabilityCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersistenceDegradabilityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PersistenceDegradabilityDescription
        {
            get
            {
                return this.persistenceDegradabilityDescriptionField;
            }
            set
            {
                this.persistenceDegradabilityDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DegradationHalfLife", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] DegradationHalfLife
        {
            get
            {
                return this.degradationHalfLifeField;
            }
            set
            {
                this.degradationHalfLifeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationAndEliminationResults DegradationAndEliminationResults
        {
            get
            {
                return this.degradationAndEliminationResultsField;
            }
            set
            {
                this.degradationAndEliminationResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DegradationInSewagePlantDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] DegradationInSewagePlantDescription
        {
            get
            {
                return this.degradationInSewagePlantDescriptionField;
            }
            set
            {
                this.degradationInSewagePlantDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChemicalOxygenDemand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] ChemicalOxygenDemand
        {
            get
            {
                return this.chemicalOxygenDemandField;
            }
            set
            {
                this.chemicalOxygenDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BiochemicalOxygenDemand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] BiochemicalOxygenDemand
        {
            get
            {
                return this.biochemicalOxygenDemandField;
            }
            set
            {
                this.biochemicalOxygenDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bod5CodRatio", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Bod5CodRatio[] Bod5CodRatio
        {
            get
            {
                return this.bod5CodRatioField;
            }
            set
            {
                this.bod5CodRatioField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TheoreticalOxygenDemand", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] TheoreticalOxygenDemand
        {
            get
            {
                return this.theoreticalOxygenDemandField;
            }
            set
            {
                this.theoreticalOxygenDemandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersistenceDegradabilityAdditionalInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PersistenceDegradabilityAdditionalInfo
        {
            get
            {
                return this.persistenceDegradabilityAdditionalInfoField;
            }
            set
            {
                this.persistenceDegradabilityAdditionalInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersistenceDegradabilityComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PersistenceDegradabilityComments
        {
            get
            {
                return this.persistenceDegradabilityCommentsField;
            }
            set
            {
                this.persistenceDegradabilityCommentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class DegradationAndEliminationResults
    {

        private BiologicalDegradation[] biologicalDegradabilityField;

        private DegradationElimination[] abioticDegradationInAirField;

        private DegradationElimination[] hydrolysisInSeaWaterField;

        private DegradationElimination[] hydrolysisInFreshWaterField;

        private DegradationElimination[] hydrolysisInSoilField;

        private DegradationElimination[] physicochemicalEliminationField;

        private DegradationElimination[] photolysisField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BiologicalDegradability", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BiologicalDegradation[] BiologicalDegradability
        {
            get
            {
                return this.biologicalDegradabilityField;
            }
            set
            {
                this.biologicalDegradabilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbioticDegradationInAir", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] AbioticDegradationInAir
        {
            get
            {
                return this.abioticDegradationInAirField;
            }
            set
            {
                this.abioticDegradationInAirField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HydrolysisInSeaWater", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] HydrolysisInSeaWater
        {
            get
            {
                return this.hydrolysisInSeaWaterField;
            }
            set
            {
                this.hydrolysisInSeaWaterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HydrolysisInFreshWater", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] HydrolysisInFreshWater
        {
            get
            {
                return this.hydrolysisInFreshWaterField;
            }
            set
            {
                this.hydrolysisInFreshWaterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HydrolysisInSoil", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] HydrolysisInSoil
        {
            get
            {
                return this.hydrolysisInSoilField;
            }
            set
            {
                this.hydrolysisInSoilField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicochemicalElimination", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] PhysicochemicalElimination
        {
            get
            {
                return this.physicochemicalEliminationField;
            }
            set
            {
                this.physicochemicalEliminationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Photolysis", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public DegradationElimination[] Photolysis
        {
            get
            {
                return this.photolysisField;
            }
            set
            {
                this.photolysisField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Bod5CodRatio
    {

        private UnitValue valueField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class Bioaccumulation
    {

        private Phrase[] bioaccumulationDescriptionField;

        private BioconcentrationFactor[] bioconcentrationFactorField;

        private Phrase[] bioaccumulationEvaluationField;

        private Phrase[] bioaccumulationCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BioaccumulationDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] BioaccumulationDescription
        {
            get
            {
                return this.bioaccumulationDescriptionField;
            }
            set
            {
                this.bioaccumulationDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BioconcentrationFactor", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public BioconcentrationFactor[] BioconcentrationFactor
        {
            get
            {
                return this.bioconcentrationFactorField;
            }
            set
            {
                this.bioconcentrationFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BioaccumulationEvaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] BioaccumulationEvaluation
        {
            get
            {
                return this.bioaccumulationEvaluationField;
            }
            set
            {
                this.bioaccumulationEvaluationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BioaccumulationComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] BioaccumulationComments
        {
            get
            {
                return this.bioaccumulationCommentsField;
            }
            set
            {
                this.bioaccumulationCommentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class BioconcentrationFactor
    {

        private UnitValue valueField;

        private Species speciesField;

        private Phrase methodField;

        private Phrase testReferenceField;

        private Phrase[] commentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public UnitValue Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Species Species
        {
            get
            {
                return this.speciesField;
            }
            set
            {
                this.speciesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase Method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase TestReference
        {
            get
            {
                return this.testReferenceField;
            }
            set
            {
                this.testReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class EcologicalInformationMobility
    {

        private Phrase[] mobilityDescriptionField;

        private Phrase[] knownOrPredictedDistributionToEnvironmentalCompartmentsField;

        private SurfaceTension[] surfaceTensionField;

        private MobilityData[] adsorptionCoefficientField;

        private MobilityData[] desorptionCoefficientField;

        private MobilityData[] waterAirVolatilityRateField;

        private MobilityData[] henryConstantField;

        private MobilityData[] soilAirVolatilityRateField;

        private Phrase[] absorptionDesorptionInfoField;

        private Phrase[] mobilityEvaluationField;

        private Phrase[] mobilityCommentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MobilityDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MobilityDescription
        {
            get
            {
                return this.mobilityDescriptionField;
            }
            set
            {
                this.mobilityDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KnownOrPredictedDistributionToEnvironmentalCompartments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] KnownOrPredictedDistributionToEnvironmentalCompartments
        {
            get
            {
                return this.knownOrPredictedDistributionToEnvironmentalCompartmentsField;
            }
            set
            {
                this.knownOrPredictedDistributionToEnvironmentalCompartmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SurfaceTension", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public SurfaceTension[] SurfaceTension
        {
            get
            {
                return this.surfaceTensionField;
            }
            set
            {
                this.surfaceTensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdsorptionCoefficient", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobilityData[] AdsorptionCoefficient
        {
            get
            {
                return this.adsorptionCoefficientField;
            }
            set
            {
                this.adsorptionCoefficientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DesorptionCoefficient", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobilityData[] DesorptionCoefficient
        {
            get
            {
                return this.desorptionCoefficientField;
            }
            set
            {
                this.desorptionCoefficientField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WaterAirVolatilityRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobilityData[] WaterAirVolatilityRate
        {
            get
            {
                return this.waterAirVolatilityRateField;
            }
            set
            {
                this.waterAirVolatilityRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HenryConstant", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobilityData[] HenryConstant
        {
            get
            {
                return this.henryConstantField;
            }
            set
            {
                this.henryConstantField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SoilAirVolatilityRate", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public MobilityData[] SoilAirVolatilityRate
        {
            get
            {
                return this.soilAirVolatilityRateField;
            }
            set
            {
                this.soilAirVolatilityRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AbsorptionDesorptionInfo", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AbsorptionDesorptionInfo
        {
            get
            {
                return this.absorptionDesorptionInfoField;
            }
            set
            {
                this.absorptionDesorptionInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MobilityEvaluation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MobilityEvaluation
        {
            get
            {
                return this.mobilityEvaluationField;
            }
            set
            {
                this.mobilityEvaluationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MobilityComments", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] MobilityComments
        {
            get
            {
                return this.mobilityCommentsField;
            }
            set
            {
                this.mobilityCommentsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class ResultsOfPbtAndVpvbAssessment
    {

        private Phrase[] pbtAssessmentResultsField;

        private Phrase[] vpvbAssessmentResultsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PbtAssessmentResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] PbtAssessmentResults
        {
            get
            {
                return this.pbtAssessmentResultsField;
            }
            set
            {
                this.pbtAssessmentResultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("VpvbAssessmentResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] VpvbAssessmentResults
        {
            get
            {
                return this.vpvbAssessmentResultsField;
            }
            set
            {
                this.vpvbAssessmentResultsField = value;
            }
        }
    }

    /// <remarks/>




    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public class OtherAdverseEffects
    {

        private Phrase[] otherAdverseEffectsDescriptionField;

        private PhysChemUnitValue[] ozoneDepletionPotentialField;

        private PhysChemUnitValue[] photochemicalOzoneCreationPotentialField;

        private PhysChemUnitValue[] globalWarmingPotentialField;

        private PhysChemUnitValue[] atmosphericLifetimeField;

        private PhysChemUnitValue[] endocrineDisruptingPotentialField;

        private FurtherEcologicalData[] dissolvedOrganicCarbonField;

        private FurtherEcologicalData[] totalOrganicCarbonField;

        private FurtherEcologicalData[] inorganicCarbonField;

        private FurtherEcologicalData[] theoreticalCarbonDioxideAmountField;

        private PhysChemUnitValue[] aOXAdsorbableOrganohalogensField;

        private PhysChemUnitValue[] pOXPurgeableOrganohalogensField;

        private PhysChemUnitValue[] eOXExtractableOrganohalogensField;

        private Phrase[] additionalEcologicalInformationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherAdverseEffectsDescription", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] OtherAdverseEffectsDescription
        {
            get
            {
                return this.otherAdverseEffectsDescriptionField;
            }
            set
            {
                this.otherAdverseEffectsDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OzoneDepletionPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] OzoneDepletionPotential
        {
            get
            {
                return this.ozoneDepletionPotentialField;
            }
            set
            {
                this.ozoneDepletionPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhotochemicalOzoneCreationPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] PhotochemicalOzoneCreationPotential
        {
            get
            {
                return this.photochemicalOzoneCreationPotentialField;
            }
            set
            {
                this.photochemicalOzoneCreationPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GlobalWarmingPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] GlobalWarmingPotential
        {
            get
            {
                return this.globalWarmingPotentialField;
            }
            set
            {
                this.globalWarmingPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AtmosphericLifetime", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] AtmosphericLifetime
        {
            get
            {
                return this.atmosphericLifetimeField;
            }
            set
            {
                this.atmosphericLifetimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EndocrineDisruptingPotential", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] EndocrineDisruptingPotential
        {
            get
            {
                return this.endocrineDisruptingPotentialField;
            }
            set
            {
                this.endocrineDisruptingPotentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DissolvedOrganicCarbon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] DissolvedOrganicCarbon
        {
            get
            {
                return this.dissolvedOrganicCarbonField;
            }
            set
            {
                this.dissolvedOrganicCarbonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TotalOrganicCarbon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] TotalOrganicCarbon
        {
            get
            {
                return this.totalOrganicCarbonField;
            }
            set
            {
                this.totalOrganicCarbonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InorganicCarbon", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] InorganicCarbon
        {
            get
            {
                return this.inorganicCarbonField;
            }
            set
            {
                this.inorganicCarbonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TheoreticalCarbonDioxideAmount", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public FurtherEcologicalData[] TheoreticalCarbonDioxideAmount
        {
            get
            {
                return this.theoreticalCarbonDioxideAmountField;
            }
            set
            {
                this.theoreticalCarbonDioxideAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AOXAdsorbableOrganohalogens", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] AOXAdsorbableOrganohalogens
        {
            get
            {
                return this.aOXAdsorbableOrganohalogensField;
            }
            set
            {
                this.aOXAdsorbableOrganohalogensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("POXPurgeableOrganohalogens", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] POXPurgeableOrganohalogens
        {
            get
            {
                return this.pOXPurgeableOrganohalogensField;
            }
            set
            {
                this.pOXPurgeableOrganohalogensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EOXExtractableOrganohalogens", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public PhysChemUnitValue[] EOXExtractableOrganohalogens
        {
            get
            {
                return this.eOXExtractableOrganohalogensField;
            }
            set
            {
                this.eOXExtractableOrganohalogensField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalEcologicalInformation", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Phrase[] AdditionalEcologicalInformation
        {
            get
            {
                return this.additionalEcologicalInformationField;
            }
            set
            {
                this.additionalEcologicalInformationField = value;
            }
        }
    }
}
