using AutoMapper;
using KAIRA.Data.Entities;
using KAIRA.Features.Mediator.Commands.GalleryCommands;
using KAIRA.Repositories.Contracts;
using MediatR;

namespace KAIRA.Features.Mediator.Handlers.GalleryHandlers
{
    public class UpdateGalleryCommandHandler : IRequestHandler<UpdateGalleryCommand>
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IMapper mapper;
        public UpdateGalleryCommandHandler(IRepositoryManager repositoryManager, IMapper mapper)
        {
            this.repositoryManager = repositoryManager;
            this.mapper = mapper;
        }
        public async Task Handle(UpdateGalleryCommand request, CancellationToken cancellationToken)
        {
            var gallery = mapper.Map<Gallery>(request);
            await repositoryManager.Gallery.UpdateAsync(gallery);
        }
    }
}
