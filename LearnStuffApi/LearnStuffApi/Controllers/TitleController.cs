using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Models.Title;

namespace LearnStuffApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TitleController(ITitleService titleService) : ControllerBase
	{
		[HttpPost(Name = "AddTitle")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddTitle(AddTitleModel model)
		{
			await titleService.AddTitle(model);
            return Ok();
		}

		[HttpGet(Name = "GetAllTitles")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> GetAllTitlesForList()
		{
            var titles = await titleService.GetAllForList();
            return Ok(titles);
		}

        [HttpPost(Name = "Borrow")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> Borrow(BorrowTitleModel model)
		{
			await titleService.Borrow(model);
            return Ok();
		}

		[HttpGet(Name = "GetWithDetails")]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> GetWithDetails(int titleId)
		{
            var title = await titleService.GetWithDetails(titleId);
            return Ok(title);
		}
	}
}
