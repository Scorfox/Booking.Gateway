﻿using Booking.Gateway.Application.Models.Client;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI.Swagger.Responses;

public class ClientGettingExamples : IMultipleExamplesProvider<ClientGettingDto>
{
    public IEnumerable<SwaggerExample<ClientGettingDto>> GetExamples()
    {
        yield return SwaggerExample.Create(
            "Client1",
            new ClientGettingDto
            {
                Id = Guid.NewGuid(),
                Email = "ivanov@gmail.com",
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                PhoneNumber = "89112223344",
                Password = "It's very StRoNg PassW0rd!1!"
            });
        
        yield return SwaggerExample.Create(
            "Client2",
            new ClientGettingDto
            {
                Id = Guid.NewGuid(),
                Email = "kabanov@gmail.com",
                LastName = "Кабанов",
                FirstName = "Петр",
                MiddleName = "Петрович",
                PhoneNumber = "89112223355",
                Password = "It's very StRoNg PassW0rd!2!"
            });
    }
}