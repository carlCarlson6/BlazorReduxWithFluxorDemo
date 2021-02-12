using demo2.Models.Todos;
using demo2.Redux.Features.Todos.Actions;
using Fluxor;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace demo2.Redux.Features.Todos.Effects
{
    public class LoadTodosEffect : Effect<LoadTodosAction>
    {
        private readonly ILogger<LoadTodosEffect> logger;
        private readonly HttpClient httpClient;

        public LoadTodosEffect(ILogger<LoadTodosEffect> logger, HttpClient httpClient) => (this.logger, this.httpClient) = (logger, httpClient);

        public override async Task HandleAsync(LoadTodosAction action, IDispatcher dispatcher)
        {
            try
            {
                this.logger.LogInformation("Loading todos ...");

                // Add a little extra latency for dramatic effect...
                await Task.Delay(TimeSpan.FromMilliseconds(1000));
                var todosResponse = await this.httpClient.GetFromJsonAsync<IEnumerable<TodoDto>>("todos");

                logger.LogInformation("Todos loaded successfully!");
                dispatcher.Dispatch(new LoadTodosSuccessAction(todosResponse));
            }
            catch(Exception exception)
            {
                this.logger.LogError($"Error loading todos, reason: {exception.Message} ");
                dispatcher.Dispatch(new LoadTodosFailureAction(exception.Message));
            }
        }
    }
}
