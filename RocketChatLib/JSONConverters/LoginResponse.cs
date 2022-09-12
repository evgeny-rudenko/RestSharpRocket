namespace RocketChatLib
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    
    public class LoginResponse { 
    public class Alert62b0e435907d6ac39e2a2d8f
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<object> TextArguments { get; set; }

        [JsonProperty("modifiers")]
        public List<object> Modifiers { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class Banners
    {
        [JsonProperty("versionUpdate-4_6_3")]
        public VersionUpdate463 VersionUpdate463 { get; set; }

        [JsonProperty("mongodbDeprecation_4_0_28")]
        public MongodbDeprecation4028 MongodbDeprecation4028 { get; set; }

        [JsonProperty("versionUpdate-4_7_0")]
        public VersionUpdate470 VersionUpdate470 { get; set; }

        [JsonProperty("versionUpdate-4_8_1")]
        public VersionUpdate481 VersionUpdate481 { get; set; }

        [JsonProperty("alert-62b0e435907d6ac39e2a2d8f")]
        public Alert62b0e435907d6ac39e2a2d8f Alert62b0e435907d6ac39e2a2d8f { get; set; }

        [JsonProperty("versionUpdate-4_8_2")]
        public VersionUpdate482 VersionUpdate482 { get; set; }

        [JsonProperty("versionUpdate-5_0_0")]
        public VersionUpdate500 VersionUpdate500 { get; set; }

        [JsonProperty("versionUpdate-5_0_1")]
        public VersionUpdate501 VersionUpdate501 { get; set; }

        [JsonProperty("versionUpdate-5_0_2")]
        public VersionUpdate502 VersionUpdate502 { get; set; }

        [JsonProperty("versionUpdate-5_0_3")]
        public VersionUpdate503 VersionUpdate503 { get; set; }

        [JsonProperty("versionUpdate-5_0_4")]
        public VersionUpdate504 VersionUpdate504 { get; set; }

        [JsonProperty("versionUpdate-5_0_5")]
        public VersionUpdate505 VersionUpdate505 { get; set; }

        [JsonProperty("versionUpdate-5_1_0")]
        public VersionUpdate510 VersionUpdate510 { get; set; }

        [JsonProperty("versionUpdate-5_1_1")]
        public VersionUpdate511 VersionUpdate511 { get; set; }
    }

    public class Data
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("authToken")]
        public string AuthToken { get; set; }

        [JsonProperty("me")]
        public Me Me { get; set; }
    }

    public class Email
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public class Me
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("services")]
        public Services Services { get; set; }

        [JsonProperty("emails")]
        public List<Email> Emails { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("statusConnection")]
        public string StatusConnection { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("utcOffset")]
        public int UtcOffset { get; set; }

        [JsonProperty("banners")]
        public Banners Banners { get; set; }

        [JsonProperty("statusText")]
        public string StatusText { get; set; }

        [JsonProperty("statusDefault")]
        public string StatusDefault { get; set; }

        [JsonProperty("avatarETag")]
        public string AvatarETag { get; set; }

        [JsonProperty("avatarOrigin")]
        public string AvatarOrigin { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }
    }

    public class MongodbDeprecation4028
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("modifiers")]
        public List<string> Modifiers { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class Password
    {
        [JsonProperty("bcrypt")]
        public string Bcrypt { get; set; }
    }

    public class Preferences
    {
        [JsonProperty("enableAutoAway")]
        public bool EnableAutoAway { get; set; }

        [JsonProperty("idleTimeLimit")]
        public int IdleTimeLimit { get; set; }

        [JsonProperty("desktopNotificationRequireInteraction")]
        public bool DesktopNotificationRequireInteraction { get; set; }

        [JsonProperty("desktopNotifications")]
        public string DesktopNotifications { get; set; }

        [JsonProperty("pushNotifications")]
        public string PushNotifications { get; set; }

        [JsonProperty("unreadAlert")]
        public bool UnreadAlert { get; set; }

        [JsonProperty("useEmojis")]
        public bool UseEmojis { get; set; }

        [JsonProperty("convertAsciiEmoji")]
        public bool ConvertAsciiEmoji { get; set; }

        [JsonProperty("autoImageLoad")]
        public bool AutoImageLoad { get; set; }

        [JsonProperty("saveMobileBandwidth")]
        public bool SaveMobileBandwidth { get; set; }

        [JsonProperty("collapseMediaByDefault")]
        public bool CollapseMediaByDefault { get; set; }

        [JsonProperty("hideUsernames")]
        public bool HideUsernames { get; set; }

        [JsonProperty("hideRoles")]
        public bool HideRoles { get; set; }

        [JsonProperty("hideFlexTab")]
        public bool HideFlexTab { get; set; }

        [JsonProperty("displayAvatars")]
        public bool DisplayAvatars { get; set; }

        [JsonProperty("sidebarGroupByType")]
        public bool SidebarGroupByType { get; set; }

        [JsonProperty("sidebarViewMode")]
        public string SidebarViewMode { get; set; }

        [JsonProperty("sidebarDisplayAvatar")]
        public bool SidebarDisplayAvatar { get; set; }

        [JsonProperty("sidebarShowUnread")]
        public bool SidebarShowUnread { get; set; }

        [JsonProperty("sidebarSortby")]
        public string SidebarSortby { get; set; }

        [JsonProperty("showMessageInMainThread")]
        public bool ShowMessageInMainThread { get; set; }

        [JsonProperty("sidebarShowFavorites")]
        public bool SidebarShowFavorites { get; set; }

        [JsonProperty("sendOnEnter")]
        public string SendOnEnter { get; set; }

        [JsonProperty("messageViewMode")]
        public int MessageViewMode { get; set; }

        [JsonProperty("emailNotificationMode")]
        public string EmailNotificationMode { get; set; }

        [JsonProperty("newRoomNotification")]
        public string NewRoomNotification { get; set; }

        [JsonProperty("newMessageNotification")]
        public string NewMessageNotification { get; set; }

        [JsonProperty("muteFocusedConversations")]
        public bool MuteFocusedConversations { get; set; }

        [JsonProperty("notificationsSoundVolume")]
        public int NotificationsSoundVolume { get; set; }

        [JsonProperty("enableMessageParserEarlyAdoption")]
        public bool EnableMessageParserEarlyAdoption { get; set; }
    }

    public class Profile
    {
    }

    public class Root
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Services
    {
        [JsonProperty("password")]
        public Password Password { get; set; }
    }

    public class Settings
    {
        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        [JsonProperty("preferences")]
        public Preferences Preferences { get; set; }
    }

    public class VersionUpdate463
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate470
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate481
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate482
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate500
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate501
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate502
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate503
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate504
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate505
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate510
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

    public class VersionUpdate511
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("textArguments")]
        public List<string> TextArguments { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }
    }

}
}