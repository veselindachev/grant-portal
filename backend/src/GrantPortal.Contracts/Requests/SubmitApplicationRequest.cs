using System.Collections.Generic;

namespace GrantPortal.Contracts.Requests;

public record SubmitApplicationRequest(IEnumerable<ApplicationAnswerRequest> Answers);

public record ApplicationAnswerRequest(string FieldId, string? Value);
