using Microsoft.AspNetCore.Mvc;
using PlaylistDomain.Domain.Input;
using PlaylistApi.Interfaces;

namespace PlaylistApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrackProposalController : ControllerBase
    {
        private readonly ILogger<TrackProposalController> _logger;
        private readonly ITrackProposalService _trackProposalService;

        public TrackProposalController(
            ILogger<TrackProposalController> logger,
            ITrackProposalService trackProposalService)
        {
            _logger = logger;
            _trackProposalService = trackProposalService;
        }

        [HttpPost]
        [Route("")]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Save([FromBody] TrackProposalInput trackProposal)
        {
            if (trackProposal == null)
            {
                _logger.LogError("TrackProposal is null");
                return BadRequest();
            }

            _trackProposalService.Save(trackProposal);
            return Accepted(trackProposal);
        }
    }
}
