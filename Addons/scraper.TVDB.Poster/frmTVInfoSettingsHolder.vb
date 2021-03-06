﻿' ################################################################################
' #                             EMBER MEDIA MANAGER                              #
' ################################################################################
' ################################################################################
' # This file is part of Ember Media Manager.                                    #
' #                                                                              #
' # Ember Media Manager is free software: you can redistribute it and/or modify  #
' # it under the terms of the GNU General Public License as published by         #
' # the Free Software Foundation, either version 3 of the License, or            #
' # (at your option) any later version.                                          #
' #                                                                              #
' # Ember Media Manager is distributed in the hope that it will be useful,       #
' # but WITHOUT ANY WARRANTY; without even the implied warranty of               #
' # MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the                #
' # GNU General Public License for more details.                                 #
' #                                                                              #
' # You should have received a copy of the GNU General Public License            #
' # along with Ember Media Manager.  If not, see <http://www.gnu.org/licenses/>. #
' ################################################################################

Imports System.IO
Imports EmberAPI

Public Class frmTVInfoSettingsHolder

#Region "Fields"

    Private _api As String

#End Region 'Fields

#Region "Events"

    Public Event ModuleSettingsChanged()

    Public Event SetupScraperChanged(ByVal state As Boolean, ByVal difforder As Integer)

    Public Event SetupNeedsRestart()

#End Region 'Events

#Region "Properties"

    Public Property API() As String
        Get
            Return Me._api
        End Get
        Set(ByVal value As String)
            Me._api = value
        End Set
    End Property

#End Region 'Properties


#Region "Methods"

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Dim order As Integer = ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.AssemblyName = TVDB_Data_Poster._AssemblyName).ScraperOrder
        If order < ModulesManager.Instance.externalTVScrapersModules.Where(Function(y) y.ProcessorModule.IsScraper).Count - 1 Then
            ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.ScraperOrder = order + 1).ScraperOrder = order
            ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.AssemblyName = TVDB_Data_Poster._AssemblyName).ScraperOrder = order + 1
            RaiseEvent SetupScraperChanged(cbEnabled.Checked, 1)
            orderChanged()
        End If
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        Dim order As Integer = ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.AssemblyName = TVDB_Data_Poster._AssemblyName).ScraperOrder
        If order > 0 Then
            ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.ScraperOrder = order - 1).ScraperOrder = order
            ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.AssemblyName = TVDB_Data_Poster._AssemblyName).ScraperOrder = order - 1
            RaiseEvent SetupScraperChanged(cbEnabled.Checked, -1)
            orderChanged()
        End If
    End Sub

    Private Sub cbEnabled_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEnabled.CheckedChanged
        RaiseEvent SetupScraperChanged(cbEnabled.Checked, 0)
    End Sub

    Public Sub New()
        _api = String.Empty
        InitializeComponent()
        Me.SetUp()
        orderChanged()
    End Sub

    Sub orderChanged()
        Dim order As Integer = ModulesManager.Instance.externalTVScrapersModules.FirstOrDefault(Function(p) p.AssemblyName = TVDB_Data_Poster._AssemblyName).ScraperOrder
        If ModulesManager.Instance.externalTVScrapersModules.Count > 0 Then
            btnDown.Enabled = (order < ModulesManager.Instance.externalTVScrapersModules.Where(Function(y) y.ProcessorModule.IsScraper).Count - 1)
            btnUp.Enabled = (order > 0)
        Else
            btnDown.Enabled = False
            btnUp.Enabled = False
        End If
    End Sub

    Private Sub SetUp()
        Me.Label2.Text = Master.eLang.GetString(168, "Scrape Order")
        Me.cbEnabled.Text = Master.eLang.GetString(774, "Enabled")
        Me.Label18.Text = Master.eLang.GetString(932, "TVDB API Key")
        Me.Label1.Text = String.Format(Master.eLang.GetString(790, "These settings are specific to this module.{0}Please refer to the global settings for more options."), vbCrLf)
        Me.gbLanguage.Text = Master.eLang.GetString(610, "Language")
        Me.lblTVLanguagePreferred.Text = Master.eLang.GetString(741, "Preferred Language:")
        Me.GroupBox30.Text = Master.eLang.GetString(941, "TVDB")
        Me.GroupBox32.Text = Master.eLang.GetString(577, "Scraper Fields - Scraper specific")
        Me.GroupBox35.Text = Master.eLang.GetString(743, "Show")
        Me.GroupBox34.Text = Master.eLang.GetString(727, "Episode")
        Me.lblTVDBMirror.Text = Master.eLang.GetString(801, "TVDB Mirror")
        Me.cbTVLanguage.Items.AddRange((From lLang In Master.eSettings.Languages Select lLang.LongLang).ToArray)
        Me.chkScraperEpActors.Text = Master.eLang.GetString(725, "Actors")
        Me.chkScraperEpAired.Text = Master.eLang.GetString(728, "Aired")
        Me.chkScraperEpCredits.Text = Master.eLang.GetString(729, "Credits")
        Me.chkScraperEpDirector.Text = Master.eLang.GetString(62, "Director")
        Me.chkScraperEpEpisode.Text = Master.eLang.GetString(755, "Episode #")
        Me.chkScraperEpPlot.Text = Master.eLang.GetString(65, "Plot")
        Me.chkScraperEpRating.Text = Master.eLang.GetString(400, "Rating")
        Me.chkScraperEpSeason.Text = Master.eLang.GetString(650, "Season")
        Me.chkScraperEpTitle.Text = Master.eLang.GetString(21, "Title")
        Me.chkScraperShowActors.Text = Master.eLang.GetString(725, "Actors")
        Me.chkScraperShowEGU.Text = Master.eLang.GetString(723, "Episode Guide URL")
        Me.chkScraperShowGenre.Text = Master.eLang.GetString(20, "Genre")
        Me.chkScraperShowMPAA.Text = Master.eLang.GetString(401, "MPAA")
        Me.chkScraperShowPlot.Text = Master.eLang.GetString(65, "Plot")
        Me.chkScraperShowPremiered.Text = Master.eLang.GetString(724, "Premiered")
        Me.chkScraperShowRating.Text = Master.eLang.GetString(400, "Rating")
        Me.chkScraperShowStudio.Text = Master.eLang.GetString(395, "Studio")
        Me.chkScraperShowTitle.Text = Master.eLang.GetString(21, "Title")
    End Sub

    Private Sub txtTVDBApiKey_TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTVDBApiKey.Enter
        _api = txtTVDBApiKey.Text
    End Sub

    Private Sub txtTVDBApiKey_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtTVDBApiKey.TextChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

    Private Sub txtTVDBApiKey_TestValidated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTVDBApiKey.Validated
        If Not (_api = txtTVDBApiKey.Text) Then
            RaiseEvent SetupNeedsRestart()
        End If
    End Sub

    Private Sub pbTVDB_Click(sender As System.Object, e As System.EventArgs) Handles pbTVDB.Click
        If Master.isWindows Then
            Process.Start("http://thetvdb.com/?tab=apiregister")
        Else
            Using Explorer As New Process
                Explorer.StartInfo.FileName = "xdg-open"
                Explorer.StartInfo.Arguments = "http://thetvdb.com/?tab=apiregister"
                Explorer.Start()
            End Using
        End If
    End Sub

    Private Sub cbTVLanguage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTVLanguage.SelectedIndexChanged
        RaiseEvent ModuleSettingsChanged()
    End Sub

#End Region 'Methods

End Class