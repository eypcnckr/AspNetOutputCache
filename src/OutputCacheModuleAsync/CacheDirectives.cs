﻿namespace Microsoft.AspNet.OutputCache {
  
    sealed class CacheDirectives {
        public const string NoCache = "no-cache";
        public const string NoStore = "no-store";
        public const string MaxAge = "max-age=";
        public const string MinFresh = "min-fresh=";
    }
}