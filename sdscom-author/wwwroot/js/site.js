//var localCache = {
//    data: {},
//    remove: function (key)
//    {
//        delete localCache.data[key];
//    },
//    exist: function (key)
//    {
//        return localCache.data.hasOwnProperty(key) && localCache.data[key] !== null;
//    },
//    get: function (key)
//    {
//        return localCache.data[key];
//    },
//    set: function (key, cachedData, callback)
//    {
//        localCache.remove(key);
//        localCache.data[key] = cachedData;
//        if ($.isFunction(callback)) callback(cachedData);
//    }
//};
