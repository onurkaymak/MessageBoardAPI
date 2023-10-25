namespace MessageBoardApi.Models
{
  public class GroupUser // Join Entity
  {
    public int GroupUserId { get; set; }
    public int GroupId { get; set; }
    public string UserId { get; set; } // user id
    public Group Group { get; set; } // reference navigation property
    public ApplicationUser User { get; set; } // reference navigation property
  }
}