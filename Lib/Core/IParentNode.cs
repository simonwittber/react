using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DifferentMethods.React
{
    public interface IParentNode
    {

        void Clear();

        void Remove(BaseNode node);

        void Add(BaseNode node);

        void Insert(int index, BaseNode node);

        BaseNode GetChild(int index);

        int IndexOf(BaseNode node);

        BaseNode[] GetChildren();
    }
}