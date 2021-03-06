﻿#region license
//Copyright 2010 Ritesh Rao 

//Licensed under the Apache License, Version 2.0 (the "License"); 
//you may not use this file except in compliance with the License. 
//You may obtain a copy of the License at 

//http://www.apache.org/licenses/LICENSE-2.0 

//Unless required by applicable law or agreed to in writing, software 
//distributed under the License is distributed on an "AS IS" BASIS, 
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
//See the License for the specific language governing permissions and 
//limitations under the License. 
#endregion

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NCommon.Data.Language
{
    ///<summary>
    ///</summary>
    ///<typeparam name="T"></typeparam>
    public class EagerFetchingPath<T> : IEagerFetchingPath<T>
    {
        readonly IList<Expression> _paths;

        ///<summary>
        /// Default Constructor.
        /// Creates a new instance of the <see cref="EagerFetchingPath{T}"/> instance.
        ///</summary>
        ///<param name="paths"></param>
        public EagerFetchingPath(IList<Expression> paths)
        {
            _paths = paths;
        }

        ///<summary>
        /// Specify an eager fetching path on <typeparamref name="T"/>.
        ///</summary>
        ///<param name="path"></param>
        ///<typeparam name="TChild"></typeparam>
        ///<returns>The eagerly fetched path.</returns>
        public IEagerFetchingPath<TChild> And<TChild>(Expression<Func<T, object>> path)
        {
            _paths.Add(path);
            return new EagerFetchingPath<TChild>(_paths);
        }
    }
}