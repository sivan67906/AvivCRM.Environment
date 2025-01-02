namespace Configuration.Application.Services;

public interface IConsumerService
{
    Task<Consumer> GetByConsumerNameAsync(string consumerName);
    Task<IEnumerable<Consumer>> SearchConsumersByNameAsync(string consumerName);
    Task<IEnumerable<Consumer>> SearchConsumersByPhoneAsync(string phoneNumber);
    Task<IEnumerable<Consumer>> SearchConsumersByDateAsync(DateTime searchDate);
    Task<IEnumerable<Consumer>> SearchConsumersByDateBetweenAsync(
        DateTime startDate, DateTime endDate);
    //Task UpdateConsumerAsync(Consumer consumer);
}
