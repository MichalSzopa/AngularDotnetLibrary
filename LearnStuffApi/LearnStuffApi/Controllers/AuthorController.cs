using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using Shared.Models.Author;

namespace LearnStuffApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorController(IAuthorService authorService) : ControllerBase
	{
		[HttpPost]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> AddAuthor(AddAuthorModel model)
		{
			var createdEntity = await authorService.AddAuthor(model);
			return CreatedAtAction(null, createdEntity);
		}

		[HttpGet]
		[ProducesResponseType(StatusCodes.Status201Created)]
		[ProducesResponseType(StatusCodes.Status400BadRequest)]
		public async Task<IActionResult> GetAllAuthors()
		{
			return Ok(await authorService.GetAll());
		}
	}
}
