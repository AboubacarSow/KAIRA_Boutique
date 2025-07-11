﻿using MediatR;

namespace KAIRA.Features.Mediator.Commands.SocialMediaCommands;

public class UpdateSocialMediaCommand:IRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Link { get; set; }
    public string Icon { get; set; }
}
