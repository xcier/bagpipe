﻿using System.Collections.Generic;

namespace bagpipe {
  public class KnownSettingInfo {
    public int ID { get; }
    public string Name { get; }
    public SettingsDataType Type { get; }

    public KnownSettingInfo(int ID, string Name, SettingsDataType Type) {
      this.ID = ID;
      this.Name = Name;
      this.Type = Type;
    }

    public bool Matches(KnownSettingInfo info) => ID == info.ID && Type == info.Type;
    public bool Matches(int ID, SettingsDataType Type) => this.ID == ID && this.Type == Type;
  }

  static class KnownSettings {
    public static readonly KnownSettingInfo UnlockedCustomizations = new KnownSettingInfo(300, "UnlockedCustomizations_MainGame", SettingsDataType.Blob);

    public static readonly KnownSettingInfo GoldenKeysEarned = new KnownSettingInfo(162, "GoldenKeysEarned", SettingsDataType.Blob);
    public static readonly KnownSettingInfo keyCount = new KnownSettingInfo(130, "keyCount", SettingsDataType.Int32);
    public static readonly KnownSettingInfo keysSpent = new KnownSettingInfo(131, "keysSpent", SettingsDataType.Int32);

    public static readonly KnownSettingInfo StashSlot0 = new KnownSettingInfo(130, "StashSlot0", SettingsDataType.Blob); // Different data type than keyCount
    public static readonly KnownSettingInfo StashSlot1 = new KnownSettingInfo(131, "StashSlot1", SettingsDataType.Blob);
    public static readonly KnownSettingInfo StashSlot2 = new KnownSettingInfo(132, "StashSlot2", SettingsDataType.Blob);
    public static readonly KnownSettingInfo StashSlot3 = new KnownSettingInfo(133, "StashSlot3", SettingsDataType.Blob);

    public static readonly KnownSettingInfo BadassPoints = new KnownSettingInfo(136, "BadassPoints", SettingsDataType.Int32);
    public static readonly KnownSettingInfo BadassPointsSpent = new KnownSettingInfo(137, "BadassPointsSpent", SettingsDataType.Int32);
    public static readonly KnownSettingInfo BadassTokens = new KnownSettingInfo(138, "BadassTokens", SettingsDataType.Int32);
    public static readonly KnownSettingInfo BadassRewardsEarned = new KnownSettingInfo(143, "BadassRewardsEarned", SettingsDataType.String);

    public static readonly IReadOnlyDictionary<Game, IReadOnlyDictionary<int, KnownSettingInfo>> ByGame = new Dictionary<Game, IReadOnlyDictionary<int, KnownSettingInfo>>() {
      { Game.BL2, new Dictionary<int, KnownSettingInfo>() {
        { 2, new KnownSettingInfo(2, "InvertGamepadLook", SettingsDataType.Int32) },
        { 16, new KnownSettingInfo(16, "AutoAim", SettingsDataType.Int32) },
        { 26, new KnownSettingInfo(26, "VersionNumber", SettingsDataType.Int32) },
        { 27, new KnownSettingInfo(27, "WriteCount", SettingsDataType.Int32) },
        { 101, new KnownSettingInfo(101, "MasterVolume", SettingsDataType.Int32) },
        { 102, new KnownSettingInfo(102, "ControllerSensitivityX", SettingsDataType.Int32) },
        { 103, new KnownSettingInfo(103, "ControllerSensitivityY", SettingsDataType.Int32) },
        { 104, new KnownSettingInfo(104, "ViewAccel", SettingsDataType.Int32) },
        { 105, new KnownSettingInfo(105, "InvertMouseLook", SettingsDataType.Int32) },
        { 106, new KnownSettingInfo(106, "IntroMovieViewed", SettingsDataType.Int32) },
        { 107, new KnownSettingInfo(107, "MusicVolume", SettingsDataType.Int32) },
        { 108, new KnownSettingInfo(108, "SFXVolume", SettingsDataType.Int32) },
        { 109, new KnownSettingInfo(109, "AcceptDuels", SettingsDataType.Int32) },
        { 110, new KnownSettingInfo(110, "AcceptTrades", SettingsDataType.Int32) },
        { 111, new KnownSettingInfo(111, "EnableSubtitles", SettingsDataType.Int32) },
        { 112, new KnownSettingInfo(112, "Brightness", SettingsDataType.Int32) },
        { 113, new KnownSettingInfo(113, "AutoAim", SettingsDataType.Int32) },
        { 114, new KnownSettingInfo(114, "HasUnlockedViralAchievement", SettingsDataType.Int32) },
        { 115, new KnownSettingInfo(115, "ControllerPreset", SettingsDataType.String) },
        { 116, new KnownSettingInfo(116, "LastSavedId", SettingsDataType.Int32) },
        { 117, new KnownSettingInfo(117, "DisableOptionalVO", SettingsDataType.Int32) },
        { 118, new KnownSettingInfo(118, "DisableTrainingMessages", SettingsDataType.Int32) },
        { 119, new KnownSettingInfo(119, "AmbientOcclusion", SettingsDataType.Int32) },
        { 120, new KnownSettingInfo(120, "HUDScaleE", SettingsDataType.Int32) },
        { 121, new KnownSettingInfo(121, "MouseSensitivity", SettingsDataType.Int32) },
        { 122, new KnownSettingInfo(122, "DlcNotifications", SettingsDataType.Int32) },
        { 124, new KnownSettingInfo(124, "VoiceVolume", SettingsDataType.Int32) },
        { 125, new KnownSettingInfo(125, "PushToTalk", SettingsDataType.Int32) },
        { 127, new KnownSettingInfo(127, "VOVolume", SettingsDataType.Int32) },
        { 128, new KnownSettingInfo(128, "PerShotForceFeedback", SettingsDataType.Int32) },
        { 129, new KnownSettingInfo(129, "PlayerFOV", SettingsDataType.Int32) },
        { 130, StashSlot0 },
        { 131, StashSlot1 },
        { 132, StashSlot2 },
        { 133, StashSlot3 },
        { 134, new KnownSettingInfo(134, "CrouchToggle", SettingsDataType.Int32) },
        { 135, new KnownSettingInfo(135, "ZoomToggle", SettingsDataType.Int32) },
        { 136, BadassPoints },
        { 137, BadassPointsSpent },
        { 138, BadassTokens },
        { 139, new KnownSettingInfo(139, "BadassTokensEarned", SettingsDataType.Int32) },
        { 140, new KnownSettingInfo(140, "AbsoluteMinimap", SettingsDataType.Int32) },
        { 141, new KnownSettingInfo(141, "HUDScaleX", SettingsDataType.Int32) },
        { 142, new KnownSettingInfo(142, "HUDScaleY", SettingsDataType.Int32) },
        { 143, BadassRewardsEarned },
        { 145, new KnownSettingInfo(145, "DriftCameraLock", SettingsDataType.Int32) },
        { 147, new KnownSettingInfo(147, "SplitDirection", SettingsDataType.Int32) },
        { 148, new KnownSettingInfo(148, "TradingDisabled", SettingsDataType.Int32) },
        { 149, new KnownSettingInfo(149, "KeyRebinding", SettingsDataType.String) },
        { 150, new KnownSettingInfo(150, "CheckedForPreviousGame", SettingsDataType.Int32) },
        { 151, new KnownSettingInfo(151, "LastNewOfferVersion", SettingsDataType.Int32) },
        { 152, new KnownSettingInfo(152, "MouseSmoothing", SettingsDataType.Int32) },
        { 153, new KnownSettingInfo(153, "ItemRotationNew", SettingsDataType.Int32) },
        { 154, new KnownSettingInfo(154, "GamepadInvertTurn", SettingsDataType.Byte) },
        { 155, new KnownSettingInfo(155, "GamepadInvertMove", SettingsDataType.Byte) },
        { 156, new KnownSettingInfo(156, "GamepadInvertStrafe", SettingsDataType.Byte) },
        { 157, new KnownSettingInfo(157, "ShouldCensorContent", SettingsDataType.Int32) },
        { 158, new KnownSettingInfo(158, "ControllerRebinding", SettingsDataType.String) },
        { 159, new KnownSettingInfo(159, "GunzerkingAutoSwitch", SettingsDataType.Byte) },
        { 160, new KnownSettingInfo(160, "EasterEggOption", SettingsDataType.Byte) },
        { 161, new KnownSettingInfo(161, "RewardedForPlayingPreviousGame", SettingsDataType.Int32) },
        { 162, GoldenKeysEarned },
        { 163, new KnownSettingInfo(163, "DisableUISway", SettingsDataType.Byte) },
        { 164, new KnownSettingInfo(164, "BadassRewardsToOfferNext", SettingsDataType.String) },
        { 165, new KnownSettingInfo(165, "InvertedReverseSteering", SettingsDataType.Byte) },
        { 166, new KnownSettingInfo(166, "BackpackSortPreference", SettingsDataType.Int32) },
        { 167, new KnownSettingInfo(167, "MouseAutoAim", SettingsDataType.Int32) },
        { 169, new KnownSettingInfo(169, "OakUpsellViewed", SettingsDataType.Empty) },
        { 300, UnlockedCustomizations },
      } },
      { Game.TPS, new Dictionary<int, KnownSettingInfo>() {
        { 2, new KnownSettingInfo(2, "InvertGamepadLook", SettingsDataType.Int32) },
        { 16, new KnownSettingInfo(16, "AutoAim", SettingsDataType.Int32) },
        { 26, new KnownSettingInfo(26, "VersionNumber", SettingsDataType.Int32) },
        { 27, new KnownSettingInfo(27, "WriteCount", SettingsDataType.Int32) },
        { 101, new KnownSettingInfo(101, "MasterVolume", SettingsDataType.Int32) },
        { 102, new KnownSettingInfo(102, "ControllerSensitivityX", SettingsDataType.Int32) },
        { 103, new KnownSettingInfo(103, "ControllerSensitivityY", SettingsDataType.Int32) },
        { 104, new KnownSettingInfo(104, "ViewAccel", SettingsDataType.Int32) },
        { 105, new KnownSettingInfo(105, "InvertMouseLook", SettingsDataType.Int32) },
        { 106, new KnownSettingInfo(106, "IntroMovieViewed", SettingsDataType.Int32) },
        { 107, new KnownSettingInfo(107, "MusicVolume", SettingsDataType.Int32) },
        { 108, new KnownSettingInfo(108, "SFXVolume", SettingsDataType.Int32) },
        { 109, new KnownSettingInfo(109, "AcceptDuels", SettingsDataType.Int32) },
        { 110, new KnownSettingInfo(110, "AcceptTrades", SettingsDataType.Int32) },
        { 111, new KnownSettingInfo(111, "EnableSubtitles", SettingsDataType.Int32) },
        { 112, new KnownSettingInfo(112, "Brightness", SettingsDataType.Int32) },
        { 113, new KnownSettingInfo(113, "AutoAim", SettingsDataType.Int32) },
        { 114, new KnownSettingInfo(114, "HasUnlockedViralAchievement", SettingsDataType.Int32) },
        { 115, new KnownSettingInfo(115, "ControllerPreset", SettingsDataType.String) },
        { 116, new KnownSettingInfo(116, "LastSavedId", SettingsDataType.Int32) },
        { 117, new KnownSettingInfo(117, "DisableOptionalVO", SettingsDataType.Int32) },
        { 118, new KnownSettingInfo(118, "DisableTrainingMessages", SettingsDataType.Int32) },
        { 119, new KnownSettingInfo(119, "AmbientOcclusion", SettingsDataType.Int32) },
        { 120, new KnownSettingInfo(120, "HUDScaleE", SettingsDataType.Int32) },
        { 121, new KnownSettingInfo(121, "MouseSensitivity", SettingsDataType.Int32) },
        { 122, new KnownSettingInfo(122, "DlcNotifications", SettingsDataType.Int32) },
        { 124, new KnownSettingInfo(124, "VoiceVolume", SettingsDataType.Int32) },
        { 125, new KnownSettingInfo(125, "PushToTalk", SettingsDataType.Int32) },
        { 127, new KnownSettingInfo(127, "VOVolume", SettingsDataType.Int32) },
        { 128, new KnownSettingInfo(128, "PerShotForceFeedback", SettingsDataType.Int32) },
        { 129, new KnownSettingInfo(129, "PlayerFOV", SettingsDataType.Int32) },
        { 130, StashSlot0 },
        { 131, StashSlot1 },
        { 132, StashSlot2 },
        { 133, StashSlot3 },
        { 134, new KnownSettingInfo(134, "CrouchToggle", SettingsDataType.Int32) },
        { 135, new KnownSettingInfo(135, "ZoomToggle", SettingsDataType.Int32) },
        { 136, BadassPoints },
        { 137, BadassPointsSpent },
        { 138, BadassTokens },
        { 139, new KnownSettingInfo(139, "BadassTokensEarned", SettingsDataType.Int32) },
        { 140, new KnownSettingInfo(140, "AbsoluteMinimap", SettingsDataType.Int32) },
        { 141, new KnownSettingInfo(141, "HUDScaleX", SettingsDataType.Int32) },
        { 142, new KnownSettingInfo(142, "HUDScaleY", SettingsDataType.Int32) },
        { 143, BadassRewardsEarned },
        { 145, new KnownSettingInfo(145, "DriftCameraLock", SettingsDataType.Int32) },
        { 147, new KnownSettingInfo(147, "SplitDirection", SettingsDataType.Int32) },
        { 148, new KnownSettingInfo(148, "TradingDisabled", SettingsDataType.Int32) },
        { 149, new KnownSettingInfo(149, "KeyRebinding", SettingsDataType.String) },
        { 150, new KnownSettingInfo(150, "CheckedForPreviousGame", SettingsDataType.Int32) },
        { 151, new KnownSettingInfo(151, "LastNewOfferVersion", SettingsDataType.Int32) },
        { 152, new KnownSettingInfo(152, "MouseSmoothing", SettingsDataType.Int32) },
        { 153, new KnownSettingInfo(153, "ItemRotationNew", SettingsDataType.Int32) },
        { 154, new KnownSettingInfo(154, "GamepadInvertTurn", SettingsDataType.Byte) },
        { 155, new KnownSettingInfo(155, "GamepadInvertMove", SettingsDataType.Byte) },
        { 156, new KnownSettingInfo(156, "GamepadInvertStrafe", SettingsDataType.Byte) },
        { 157, new KnownSettingInfo(157, "ShouldCensorContent", SettingsDataType.Byte) },
        { 158, new KnownSettingInfo(158, "ControllerRebinding", SettingsDataType.String) },
        { 159, new KnownSettingInfo(159, "GunzerkingAutoSwitch", SettingsDataType.Byte) },
        { 160, new KnownSettingInfo(160, "EasterEggOption", SettingsDataType.Byte) },
        { 161, new KnownSettingInfo(161, "RewardedForPlayingPreviousGame", SettingsDataType.Int32) },
        { 162, GoldenKeysEarned },
        { 163, new KnownSettingInfo(163, "DisableUISway", SettingsDataType.Byte) },
        { 164, new KnownSettingInfo(164, "BadassRewardsToOfferNext", SettingsDataType.String) },
        { 165, new KnownSettingInfo(165, "InvertedReverseSteering", SettingsDataType.Byte) },
        { 166, new KnownSettingInfo(166, "BackpackSortPreference", SettingsDataType.Int32) },
        { 167, new KnownSettingInfo(167, "MoonstoneRewardEarned", SettingsDataType.Int32) },
        { 168, new KnownSettingInfo(168, "ResetCameraOnSlam", SettingsDataType.Int32) },
        { 169, new KnownSettingInfo(169, "MouseAutoAim", SettingsDataType.Int32) },
        { 171, new KnownSettingInfo(171, "ItemRewardEarnedForBL1", SettingsDataType.Int32) },
        { 172, new KnownSettingInfo(172, "ItemRewardEarnedForBL2", SettingsDataType.Int32) },
        { 173, new KnownSettingInfo(173, "BadassRankChanged", SettingsDataType.Int32) },
        { 174, new KnownSettingInfo(174, "OpenedShiftGifts", SettingsDataType.String) },
        { 175, new KnownSettingInfo(175, "OptInShiftEvents", SettingsDataType.Int32) },
        { 176, new KnownSettingInfo(176, "BadassPointsRewardEarned", SettingsDataType.Int32) },
        { 178, new KnownSettingInfo(178, "OakUpsellViewed", SettingsDataType.Empty) },
        { 300, UnlockedCustomizations },
      } },
      { Game.AoDK, new Dictionary<int, KnownSettingInfo>() {
        { 2, new KnownSettingInfo(2, "InvertGamepadLook", SettingsDataType.Int32) },
        { 16, new KnownSettingInfo(16, "AutoAim", SettingsDataType.Int32) },
        { 26, new KnownSettingInfo(26, "VersionNumber", SettingsDataType.Int32) },
        { 27, new KnownSettingInfo(27, "WriteCount", SettingsDataType.Int32) },
        { 101, new KnownSettingInfo(101, "MasterVolume", SettingsDataType.Int32) },
        { 102, new KnownSettingInfo(102, "ControllerSensitivityX", SettingsDataType.Int32) },
        { 103, new KnownSettingInfo(103, "ControllerSensitivityY", SettingsDataType.Int32) },
        { 104, new KnownSettingInfo(104, "ViewAccel", SettingsDataType.Int32) },
        { 105, new KnownSettingInfo(105, "InvertMouseLook", SettingsDataType.Int32) },
        { 106, new KnownSettingInfo(106, "IntroMovieViewed", SettingsDataType.Byte) },
        { 107, new KnownSettingInfo(107, "MusicVolume", SettingsDataType.Int32) },
        { 108, new KnownSettingInfo(108, "SFXVolume", SettingsDataType.Int32) },
        { 109, new KnownSettingInfo(109, "AcceptDuels", SettingsDataType.Int32) },
        { 110, new KnownSettingInfo(110, "AcceptTrades", SettingsDataType.Int32) },
        { 111, new KnownSettingInfo(111, "EnableSubtitles", SettingsDataType.Int32) },
        { 112, new KnownSettingInfo(112, "Brightness", SettingsDataType.Int32) },
        { 113, new KnownSettingInfo(113, "AutoAim", SettingsDataType.Int32) },
        { 114, new KnownSettingInfo(114, "HasUnlockedViralAchievement", SettingsDataType.Int32) },
        { 115, new KnownSettingInfo(115, "ControllerPreset", SettingsDataType.String) },
        { 116, new KnownSettingInfo(116, "LastSavedId", SettingsDataType.Int32) },
        { 117, new KnownSettingInfo(117, "DisableOptionalVO", SettingsDataType.Int32) },
        { 118, new KnownSettingInfo(118, "DisableTrainingMessages", SettingsDataType.Int32) },
        { 119, new KnownSettingInfo(119, "AmbientOcclusion", SettingsDataType.Int32) },
        { 120, new KnownSettingInfo(120, "HUDScaleE", SettingsDataType.Int32) },
        { 121, new KnownSettingInfo(121, "MouseSensitivity", SettingsDataType.Int32) },
        { 122, new KnownSettingInfo(122, "DlcNotifications", SettingsDataType.Int32) },
        { 124, new KnownSettingInfo(124, "VoiceVolume", SettingsDataType.Int32) },
        { 125, new KnownSettingInfo(125, "PushToTalk", SettingsDataType.Int32) },
        { 127, new KnownSettingInfo(127, "VOVolume", SettingsDataType.Int32) },
        { 128, new KnownSettingInfo(128, "PerShotForceFeedback", SettingsDataType.Int32) },
        { 129, new KnownSettingInfo(129, "PlayerFOV", SettingsDataType.Int32) },
        { 130, StashSlot0 },
        { 131, StashSlot1 },
        { 132, StashSlot2 },
        { 133, StashSlot3 },
        { 134, new KnownSettingInfo(134, "CrouchToggle", SettingsDataType.Int32) },
        { 135, new KnownSettingInfo(135, "ZoomToggle", SettingsDataType.Int32) },
        { 136, BadassPoints },
        { 137, BadassPointsSpent },
        { 138, BadassTokens },
        { 139, new KnownSettingInfo(139, "BadassTokensEarned", SettingsDataType.Int32) },
        { 140, new KnownSettingInfo(140, "AbsoluteMinimap", SettingsDataType.Int32) },
        { 141, new KnownSettingInfo(141, "HUDScaleX", SettingsDataType.Int32) },
        { 142, new KnownSettingInfo(142, "HUDScaleY", SettingsDataType.Int32) },
        { 143, BadassRewardsEarned },
        { 145, new KnownSettingInfo(145, "DriftCameraLock", SettingsDataType.Int32) },
        { 147, new KnownSettingInfo(147, "SplitDirection", SettingsDataType.Int32) },
        { 148, new KnownSettingInfo(148, "TradingDisabled", SettingsDataType.Int32) },
        { 149, new KnownSettingInfo(149, "KeyRebinding", SettingsDataType.String) },
        { 150, new KnownSettingInfo(150, "CheckedForPreviousGame", SettingsDataType.Int32) },
        { 151, new KnownSettingInfo(151, "LastNewOfferVersion", SettingsDataType.Int32) },
        { 152, new KnownSettingInfo(152, "MouseSmoothing", SettingsDataType.Int32) },
        { 153, new KnownSettingInfo(153, "ItemRotationNew", SettingsDataType.Int32) },
        { 154, new KnownSettingInfo(154, "GamepadInvertTurn", SettingsDataType.Byte) },
        { 155, new KnownSettingInfo(155, "GamepadInvertMove", SettingsDataType.Byte) },
        { 156, new KnownSettingInfo(156, "GamepadInvertStrafe", SettingsDataType.Byte) },
        { 157, new KnownSettingInfo(157, "ShouldCensorContent", SettingsDataType.Byte) },
        { 158, new KnownSettingInfo(158, "ControllerRebinding", SettingsDataType.String) },
        { 159, new KnownSettingInfo(159, "GunzerkingAutoSwitch", SettingsDataType.Byte) },
        { 160, new KnownSettingInfo(160, "EasterEggOption", SettingsDataType.Byte) },
        { 161, new KnownSettingInfo(161, "RewardedForPlayingPreviousGame", SettingsDataType.Byte) },
        { 162, GoldenKeysEarned },
        { 163, new KnownSettingInfo(163, "DisableUISway", SettingsDataType.Byte) },
        { 164, new KnownSettingInfo(164, "BadassRewardsToOfferNext", SettingsDataType.String) },
        { 165, new KnownSettingInfo(165, "InvertedReverseSteering", SettingsDataType.Byte) },
        { 166, new KnownSettingInfo(166, "BackpackSortPreference", SettingsDataType.Int32) },
        { 167, new KnownSettingInfo(167, "MouseAutoAim", SettingsDataType.Int32) },
        { 169, new KnownSettingInfo(169, "OakUpsellViewed", SettingsDataType.Int32) },
        { 170, new KnownSettingInfo(170, "ShowSubtitleBackground", SettingsDataType.Int32) },
        { 171, new KnownSettingInfo(171, "EasyMode", SettingsDataType.Int32) },
        { 300, UnlockedCustomizations},
      } }
    };
  }
}
