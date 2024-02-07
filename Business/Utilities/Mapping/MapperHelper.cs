using AutoMapper;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Mapping;

public class MapperHelper : IMapperHelper
{
	private readonly IMapper _mapper;

	public MapperHelper()
	{
		var profiles = new List<Profile>
		{
			new Profiles()
		};

		var config = new MapperConfiguration(cfg =>
		{
			foreach (var profile in profiles)
			{
				cfg.AddProfile(profile);
			}
		});

		_mapper = config.CreateMapper();
	}

	public TDestination Map<TDestination>(object? source)
	{
		return _mapper.Map<TDestination>(source);
	}

	public void Map(object? source, object? destination)
	{
		if (source == null || destination == null)
		{
			throw new ArgumentNullException("Source and destination objects must not be null.");
		}

		_mapper.Map(source, destination);
	}
}
