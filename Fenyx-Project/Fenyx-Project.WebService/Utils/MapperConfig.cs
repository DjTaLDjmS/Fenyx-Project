using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppForm.WebServices.Utils
{
    public static class MapperConfig
    {
        private static IMapper _modelMapper;
        private static readonly object _mapperLocker = new object();

        public static IMapper ModelMapper
        {
            get
            {
                lock (_mapperLocker)
                {
                    if (_modelMapper == null)
                    {
                        var config = new MapperConfiguration(cfg => cfg.AddProfile(new UserProfile()));
                        _modelMapper = config.CreateMapper();
                    }
                }

                return _modelMapper;
            }
        }
    }
}