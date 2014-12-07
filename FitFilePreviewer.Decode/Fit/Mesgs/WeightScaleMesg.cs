#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2014 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 12.20Release
// Tag = $Name$
////////////////////////////////////////////////////////////////////////////////

#endregion

namespace FitFilePreviewer.Decode.Fit.Mesgs
{
   /// <summary>
   /// Implements the WeightScale profile message.
   /// </summary>  
   public class WeightScaleMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public WeightScaleMesg() : base((Mesg) Profile.mesgs[Profile.WeightScaleIndex])               
      {                 
      }
      
      public WeightScaleMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the Timestamp field
      /// Units: s</summary>
      /// <returns>Returns DateTime representing the Timestamp field</returns>      
      public Types.DateTime GetTimestamp()   
      {                
         return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));                     
      }

      /// <summary>        
      /// Set Timestamp field
      /// Units: s</summary>
      /// <param name="timestamp_">Nullable field value to be set</param>      
      public void SetTimestamp(Types.DateTime timestamp_) 
      {  
         SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Weight field
      /// Units: kg</summary>
      /// <returns>Returns nullable float representing the Weight field</returns>      
      public float? GetWeight()   
      {                
         return (float?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Weight field
      /// Units: kg</summary>
      /// <param name="weight_">Nullable field value to be set</param>      
      public void SetWeight(float? weight_) 
      {  
         SetFieldValue(0, 0, weight_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the PercentFat field
      /// Units: %</summary>
      /// <returns>Returns nullable float representing the PercentFat field</returns>      
      public float? GetPercentFat()   
      {                
         return (float?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set PercentFat field
      /// Units: %</summary>
      /// <param name="percentFat_">Nullable field value to be set</param>      
      public void SetPercentFat(float? percentFat_) 
      {  
         SetFieldValue(1, 0, percentFat_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the PercentHydration field
      /// Units: %</summary>
      /// <returns>Returns nullable float representing the PercentHydration field</returns>      
      public float? GetPercentHydration()   
      {                
         return (float?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set PercentHydration field
      /// Units: %</summary>
      /// <param name="percentHydration_">Nullable field value to be set</param>      
      public void SetPercentHydration(float? percentHydration_) 
      {  
         SetFieldValue(2, 0, percentHydration_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the VisceralFatMass field
      /// Units: kg</summary>
      /// <returns>Returns nullable float representing the VisceralFatMass field</returns>      
      public float? GetVisceralFatMass()   
      {                
         return (float?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set VisceralFatMass field
      /// Units: kg</summary>
      /// <param name="visceralFatMass_">Nullable field value to be set</param>      
      public void SetVisceralFatMass(float? visceralFatMass_) 
      {  
         SetFieldValue(3, 0, visceralFatMass_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BoneMass field
      /// Units: kg</summary>
      /// <returns>Returns nullable float representing the BoneMass field</returns>      
      public float? GetBoneMass()   
      {                
         return (float?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BoneMass field
      /// Units: kg</summary>
      /// <param name="boneMass_">Nullable field value to be set</param>      
      public void SetBoneMass(float? boneMass_) 
      {  
         SetFieldValue(4, 0, boneMass_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the MuscleMass field
      /// Units: kg</summary>
      /// <returns>Returns nullable float representing the MuscleMass field</returns>      
      public float? GetMuscleMass()   
      {                
         return (float?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set MuscleMass field
      /// Units: kg</summary>
      /// <param name="muscleMass_">Nullable field value to be set</param>      
      public void SetMuscleMass(float? muscleMass_) 
      {  
         SetFieldValue(5, 0, muscleMass_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BasalMet field
      /// Units: kcal/day</summary>
      /// <returns>Returns nullable float representing the BasalMet field</returns>      
      public float? GetBasalMet()   
      {                
         return (float?)GetFieldValue(7, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BasalMet field
      /// Units: kcal/day</summary>
      /// <param name="basalMet_">Nullable field value to be set</param>      
      public void SetBasalMet(float? basalMet_) 
      {  
         SetFieldValue(7, 0, basalMet_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the PhysiqueRating field</summary>
      /// <returns>Returns nullable byte representing the PhysiqueRating field</returns>      
      public byte? GetPhysiqueRating()   
      {                
         return (byte?)GetFieldValue(8, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set PhysiqueRating field</summary>
      /// <param name="physiqueRating_">Nullable field value to be set</param>      
      public void SetPhysiqueRating(byte? physiqueRating_) 
      {  
         SetFieldValue(8, 0, physiqueRating_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the ActiveMet field
      /// Units: kcal/day
      /// Comment: ~4kJ per kcal, 0.25 allows max 16384 kcal</summary>
      /// <returns>Returns nullable float representing the ActiveMet field</returns>      
      public float? GetActiveMet()   
      {                
         return (float?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set ActiveMet field
      /// Units: kcal/day
      /// Comment: ~4kJ per kcal, 0.25 allows max 16384 kcal</summary>
      /// <param name="activeMet_">Nullable field value to be set</param>      
      public void SetActiveMet(float? activeMet_) 
      {  
         SetFieldValue(9, 0, activeMet_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the MetabolicAge field
      /// Units: years</summary>
      /// <returns>Returns nullable byte representing the MetabolicAge field</returns>      
      public byte? GetMetabolicAge()   
      {                
         return (byte?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set MetabolicAge field
      /// Units: years</summary>
      /// <param name="metabolicAge_">Nullable field value to be set</param>      
      public void SetMetabolicAge(byte? metabolicAge_) 
      {  
         SetFieldValue(10, 0, metabolicAge_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the VisceralFatRating field</summary>
      /// <returns>Returns nullable byte representing the VisceralFatRating field</returns>      
      public byte? GetVisceralFatRating()   
      {                
         return (byte?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set VisceralFatRating field</summary>
      /// <param name="visceralFatRating_">Nullable field value to be set</param>      
      public void SetVisceralFatRating(byte? visceralFatRating_) 
      {  
         SetFieldValue(11, 0, visceralFatRating_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the UserProfileIndex field
      /// Comment: Associates this weight scale message to a user.  This corresponds to the index of the user profile message in the weight scale file.</summary>
      /// <returns>Returns nullable ushort representing the UserProfileIndex field</returns>      
      public ushort? GetUserProfileIndex()   
      {                
         return (ushort?)GetFieldValue(12, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set UserProfileIndex field
      /// Comment: Associates this weight scale message to a user.  This corresponds to the index of the user profile message in the weight scale file.</summary>
      /// <param name="userProfileIndex_">Nullable field value to be set</param>      
      public void SetUserProfileIndex(ushort? userProfileIndex_) 
      {  
         SetFieldValue(12, 0, userProfileIndex_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
