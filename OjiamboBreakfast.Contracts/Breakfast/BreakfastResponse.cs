namespace OjiamboBreakfast.Contracts.Breakfast;
public record CreateBreakfastResponse(
    string Name,
    string Description,
    DateTime EndDateTime,
    DateTime LastModifiedDateTime,
    List<string>Savory,
    List<string>Sweet
    );