using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditMethods
{
    public class T5Data
    {
        public object user_flair_background_color { get; set; }
        public string submit_text_html { get; set; }
        public bool? user_flair_enabled_in_sr { get; set; }
        public bool? user_is_banned { get; set; }
        public bool? free_form_reports { get; set; }
        public object wiki_enabled { get; set; }
        public bool? user_is_muted { get; set; }
        public object user_can_flair_in_sr { get; set; }
        public string display_name { get; set; }
        public object header_img { get; set; }
        public string title { get; set; }
        public List<int> icon_size { get; set; }
        public string primary_color { get; set; }
        public object active_user_count { get; set; }
        public string icon_img { get; set; }
        public string display_name_prefixed { get; set; }
        public object accounts_active { get; set; }
        public bool? public_traffic { get; set; }
        public int subscribers { get; set; }
        public List<object> user_flair_richtext { get; set; }
        public int videostream_links_count { get; set; }
        public string name { get; set; }
        public bool? quarantine { get; set; }
        public bool? hide_ads { get; set; }
        public bool? emojis_enabled { get; set; }
        public string advertiser_category { get; set; }
        public string public_description { get; set; }
        public int comment_score_hide_mins { get; set; }
        public bool? user_has_favorited { get; set; }
        public object user_flair_template_id { get; set; }
        public string community_icon { get; set; }
        public string banner_background_image { get; set; }
        public bool? original_content_tag_enabled { get; set; }
        public string submit_text { get; set; }
        public string description_html { get; set; }
        public bool? spoilers_enabled { get; set; }
        public string header_title { get; set; }
        public object header_size { get; set; }
        public string user_flair_position { get; set; }
        public bool? is_default_icon { get; set; }
        public bool? all_original_content { get; set; }
        public bool? has_menu_widget { get; set; }
        public object is_enrolled_in_new_modmail { get; set; }
        public string key_color { get; set; }
        public bool? can_assign_user_flair { get; set; }
        public double created { get; set; }
        public object wls { get; set; }
        public bool? show_media_preview { get; set; }
        public string submission_type { get; set; }
        public bool? user_is_subscriber { get; set; }
        public bool? allow_videogifs { get; set; }
        public string user_flair_type { get; set; }
        public bool? collapse_deleted_comments { get; set; }
        public object emojis_custom_size { get; set; }
        public string public_description_html { get; set; }
        public bool? allow_videos { get; set; }
        public string suggested_comment_sort { get; set; }
        public bool? can_assign_link_flair { get; set; }
        public bool? accounts_active_is_fuzzed { get; set; }
        public string submit_text_label { get; set; }
        public string link_flair_position { get; set; }
        public object user_sr_flair_enabled { get; set; }
        public bool? is_default_banner { get; set; }
        public bool? allow_discovery { get; set; }
        public bool? user_sr_theme_enabled { get; set; }
        public bool? link_flair_enabled { get; set; }
        public string subreddit_type { get; set; }
        public object notification_level { get; set; }
        public string banner_img { get; set; }
        public object user_flair_text { get; set; }
        public string banner_background_color { get; set; }
        public bool? show_media { get; set; }
        public string id { get; set; }
        public bool? user_is_moderator { get; set; }
        public bool? over18 { get; set; }
        public string description { get; set; }
        public string submit_link_label { get; set; }
        public object user_flair_text_color { get; set; }
        public object user_flair_css_class { get; set; }
        public bool? allow_images { get; set; }
        public string lang { get; set; }
        public object whitelist_status { get; set; }
        public string url { get; set; }
        public double created_utc { get; set; }
        public List<int?> banner_size { get; set; }
        public bool? user_is_contributor { get; set; }
    }

    public class Child
    {
        public string kind { get; set; }
        public T5Data data { get; set; }
    }

    public class Data
    {
        public string modhash { get; set; }
        public int dist { get; set; }
        public List<Child> children { get; set; }
        public string after { get; set; }
        public object before { get; set; }
    }

    public class RootObject
    {
        public string kind { get; set; }
        public Data data { get; set; }
    }
}
