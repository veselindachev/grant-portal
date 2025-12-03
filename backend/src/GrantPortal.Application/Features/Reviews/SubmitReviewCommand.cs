using GrantPortal.Application.Abstractions.Messaging;
using GrantPortal.Application.DTOs.Reviews;

namespace GrantPortal.Application.Features.Reviews;

public record SubmitReviewCommand(Guid ApplicationId, Guid ReviewerId, int Score, string Comments) : ICommand<ReviewDto>;
