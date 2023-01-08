namespace OjiamboBreakfast.Contracts.Breakfast;
public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime EndDateTime,
    List<string>Savory,
    List<string>Sweet
    );