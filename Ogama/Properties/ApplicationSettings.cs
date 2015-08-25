// <copyright file="ApplicationSettings.cs" company="FU Berlin">
// ******************************************************
// OGAMA - open gaze and mouse analyzer 
// Copyright (C) 2015 Dr. Adrian Vo�k�hler  
// ------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation; either version 2 of the License, or (at your option) any later version.
// This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
// You should have received a copy of the GNU General Public License along with this program; if not, write to the Free Software Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// **************************************************************
// </copyright>
// <author>Adrian Vo�k�hler</author>
// <email>adrian@ogama.net</email>

namespace Ogama.Properties
{
  using System.IO;
  using System.Windows.Forms;

  /// <summary>
  /// Program and user settings class provided by Visual Studio.
  /// Main part is automatically generated by properties window.
  /// Has application and user scoped form designer generated settings.
  /// </summary>
  /// <remarks>
  /// This class also allows you to handle specific events on the settings class:
  ///  The SettingChanging event is raised before a setting's value is changed.
  ///  The PropertyChanged event is raised after a setting's value is changed.
  ///  The SettingsLoaded event is raised after the setting values are loaded.
  ///  The SettingsSaving event is raised before the setting values are saved.
  /// For custom settings on experiments refer to the class 
  /// <see cref="Properties.ExperimentSettings"/>.
  /// </remarks>
  internal sealed partial class Settings
  {
    ///////////////////////////////////////////////////////////////////////////////
    // Defining Constants                                                        //
    ///////////////////////////////////////////////////////////////////////////////
    #region CONSTANTS
    #endregion //CONSTANTS

    ///////////////////////////////////////////////////////////////////////////////
    // Defining Variables, Enumerations, Events                                  //
    ///////////////////////////////////////////////////////////////////////////////
    #region FIELDS
    #endregion //FIELDS

    ///////////////////////////////////////////////////////////////////////////////
    // Defining Properties                                                       //
    ///////////////////////////////////////////////////////////////////////////////
    #region PROPERTIES
    #endregion //PROPERTIES

    ///////////////////////////////////////////////////////////////////////////////
    // Construction and Initializing methods                                     //
    ///////////////////////////////////////////////////////////////////////////////
    #region CONSTRUCTION

    /// <summary>
    /// Initializes a new instance of the Settings class.
    /// </summary>
    public Settings()
    {
      // Setup v
      // Do not create directory if it does not already exists
      // because it will be created during first startup
      // of Record Module
      this.OgamaScreenCaptureSettingsPath = Directory.GetParent(Application.CommonAppDataPath).FullName +
        Path.DirectorySeparatorChar;

      // Setup SaliencyCalculationPath
      // Do not create directory if it does not already exists
      // because it will be created during first startup
      // of Saliency Module
      this.SaliencyCalculationPath = Application.UserAppDataPath +
        Path.DirectorySeparatorChar + "SaliencyCalculation" +
        Path.DirectorySeparatorChar;

      // Setup LogfilePath
      this.LogfilePath = Application.UserAppDataPath +
        Path.DirectorySeparatorChar + "Logs" +
        Path.DirectorySeparatorChar;

      // Create directory if not already existing.
      if (!Directory.Exists(this.LogfilePath))
      {
        Directory.CreateDirectory(this.LogfilePath);
      }

      // Setup ImportSettingsPath
      this.ImportSettingsPath = Application.UserAppDataPath +
        Path.DirectorySeparatorChar + "ImportSettings" +
        Path.DirectorySeparatorChar;

      // Create directory if not already existing.
      if (!Directory.Exists(this.ImportSettingsPath))
      {
        Directory.CreateDirectory(this.ImportSettingsPath);
      }

      // Check for existing tracker settings path.      
      // Move path of older version to new location
      if (!Directory.Exists(this.EyeTrackerSettingsPath)
        || !this.EyeTrackerSettingsPath.Contains(Application.UserAppDataPath))
      {
        this.EyeTrackerSettingsPath = Application.UserAppDataPath +
          Path.DirectorySeparatorChar + "ITrackerSettings" +
          Path.DirectorySeparatorChar;

        // Create directory if not already existing.
        if (!Directory.Exists(this.EyeTrackerSettingsPath))
        {
          Directory.CreateDirectory(this.EyeTrackerSettingsPath);
        }

        // Move settings files to new Local Application Data Directory
        string oldAleaSettingsFile = Path.Combine(Application.StartupPath, "AleaSetting.xml");
        string oldTobiiSettingsFile = Path.Combine(Application.StartupPath, "TobiiSetting.xml");
        string oldMouseOnlySettingsFile = Path.Combine(Application.StartupPath, "MouseOnlySetting.xml");
        string oldAslSettingsFile = Path.Combine(Application.StartupPath, "AslSetting.xml");
        string newAleaSettingsFile = Path.Combine(this.EyeTrackerSettingsPath, "AleaSetting.xml");
        string newTobiiSettingsFile = Path.Combine(this.EyeTrackerSettingsPath, "TobiiSetting.xml");
        string newMouseOnlySettingsFile = Path.Combine(this.EyeTrackerSettingsPath, "MouseOnlySetting.xml");
        string newAslSettingsFile = Path.Combine(this.EyeTrackerSettingsPath, "AslSetting.xml");
        if (File.Exists(oldAleaSettingsFile) && !File.Exists(newAleaSettingsFile))
        {
          File.Copy(oldAleaSettingsFile, newAleaSettingsFile);
        }

        if (File.Exists(oldTobiiSettingsFile) && !File.Exists(newTobiiSettingsFile))
        {
          File.Copy(oldTobiiSettingsFile, newTobiiSettingsFile);
        }

        if (File.Exists(oldMouseOnlySettingsFile) && !File.Exists(newMouseOnlySettingsFile))
        {
          File.Copy(oldMouseOnlySettingsFile, newMouseOnlySettingsFile);
        }

        if (File.Exists(oldAslSettingsFile) && !File.Exists(newAslSettingsFile))
        {
          File.Copy(oldAslSettingsFile, newAslSettingsFile);
        }
      }
    }

    #endregion //CONSTRUCTION

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler                                                              //
    ///////////////////////////////////////////////////////////////////////////////
    #region EVENTS

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler for UI, Menu, Buttons, Toolbars etc.                         //
    ///////////////////////////////////////////////////////////////////////////////
    #region WINDOWSEVENTHANDLER
    #endregion //WINDOWSEVENTHANDLER

    ///////////////////////////////////////////////////////////////////////////////
    // Eventhandler for Custom Defined Events                                    //
    ///////////////////////////////////////////////////////////////////////////////
    #region CUSTOMEVENTHANDLER
    #endregion //CUSTOMEVENTHANDLER

    #endregion //EVENTS

    ///////////////////////////////////////////////////////////////////////////////
    // Methods and Eventhandling for Background tasks                            //
    ///////////////////////////////////////////////////////////////////////////////
    #region BACKGROUNDWORKER
    #endregion //BACKGROUNDWORKER

    ///////////////////////////////////////////////////////////////////////////////
    // Inherited methods                                                         //
    ///////////////////////////////////////////////////////////////////////////////
    #region OVERRIDES
    #endregion //OVERRIDES

    ///////////////////////////////////////////////////////////////////////////////
    // Methods for doing main class job                                          //
    ///////////////////////////////////////////////////////////////////////////////
    #region METHODS
    #endregion //METHODS

    ///////////////////////////////////////////////////////////////////////////////
    // Small helping Methods                                                     //
    ///////////////////////////////////////////////////////////////////////////////
    #region HELPER
    #endregion //HELPER
  }
}