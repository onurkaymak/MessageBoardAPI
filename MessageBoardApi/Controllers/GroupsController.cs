using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MessageBoardApi.Models;
using Microsoft.AspNetCore.Authorization;
// using MessageBoardApi.Migrations;

namespace MessageBoardApi.Controllers;

[Route("api/[controller]")]
[ApiController]

public class GroupsController : ControllerBase
{
  private readonly MessageBoardApiContext _db;

  public GroupsController(MessageBoardApiContext db)
  {
    _db = db;
  }

  // GET: api/groups
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Group>>> Get()
  {
    IQueryable<Group> query = _db.Groups.AsQueryable();
    return await query
                      .Include(group => group.Messages)
                      .ThenInclude(m => m.User)
                      .ToListAsync();
  }

  // GET: api/groups/{id}
  [HttpGet("{id}")]
  public async Task<ActionResult<Group>> GetGroup(int id)
  {
    Group thisGroup = await _db.Groups
                                    .Include(group => group.Messages)
                                    .ThenInclude(m => m.User)
                                    .FirstOrDefaultAsync(group => group.GroupId == id);
    if (thisGroup == null)
    {
      return NotFound();
    }
    return thisGroup;
  }

  [HttpGet("{id}/messages/{messageId}")]
  public async Task<ActionResult<IEnumerable<Message>>> GetMessage(int id, int messageId)
  {
    IQueryable<Message> query = _db.Messages.Where(m => m.GroupId == id)
                                            .Where(m => m.MessageId == messageId)
                                            .AsQueryable();

    return await query.ToListAsync();
  }

  [HttpPost("{id}/messages")]
  [Authorize]
  public async Task<ActionResult<Message>> PostMessage(int id, Message message)
  {
    message.GroupId = id;
    message.UserId = User.Claims.Where(u => u.Type == "userId").FirstOrDefault().Value;
    message.Date = DateTime.Now;
    _db.Messages.Add(message);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetMessage), new { id = id, messageId = message.MessageId }, message);
  }
}