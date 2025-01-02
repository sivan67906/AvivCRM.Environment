namespace AvivCRM.Environment.Domain.Entities;
public class Message
{
    public Guid Id { get; set; }
    public bool AllowChatClientEmployee {  get; set; }
    public bool All {  get; set; }
    public bool OnlyProjectMembercanwithclient {  get; set; }
    public bool Allowchatclientadmin {  get; set; }
    public bool SoundNotifyAlert { get; set; }
}
