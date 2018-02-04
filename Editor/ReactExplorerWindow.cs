using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Linq;
using System.IO;
using System.Text;
using UnityEditor.Callbacks;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using DifferentMethods.React.Generation;


namespace DifferentMethods.React.Editor
{


    public class ReactExplorerWindow : ReactSearchWindow, ISerializationCallbackReceiver
    {
        Dictionary<string, List<SearchResult>> categories = new Dictionary<string, List<SearchResult>>();
        string showCategory = "";
        private Vector2 scroll;
        private Rect view;
        GUIStyle categoryStyle;

        protected void OnEnable()
        {
            titleContent = new GUIContent("Node Explorer", EditorGUIUtility.Load("React/ReactIcon.png") as Texture2D);
            categories["Core"] = new List<SearchResult>();

            foreach (var registeredType in ReactTypeRegister.AllTypes)
            {
                var type = registeredType.type;
                if (ReactTypeRegister.IsCoreNode(type) || ReactTypeRegister.IsCoreDecorator(type))
                {
                    categories["Core"].Add(new SearchResult() { niceName = registeredType.niceName, type = registeredType.type, signature = registeredType.signature });
                }
                else
                {
                    var parts = registeredType.menuPath.Split('/');
                    List<SearchResult> results;
                    if (!categories.TryGetValue(parts[0], out results))
                        results = categories[parts[0]] = new List<SearchResult>();
                    results.Add(new SearchResult() { niceName = registeredType.niceName, type = registeredType.type, signature = registeredType.signature });
                }
            }
            view = position;
        }

        protected override void UpdateSearchResults()
        {
            searchResults.Clear();
            if (categories.ContainsKey(showCategory))
                searchResults.AddRange(categories[showCategory].Where((A) =>
                {
                    return target.IsValidParent(A.type, target.reactor.hotNode);
                }));
        }

        protected override void OnGUI()
        {
            categoryStyle = EditorStyles.miniButton;
            categoryStyle.padding = new RectOffset(32, 32, 1, 1);
            categoryStyle.alignment = TextAnchor.MiddleLeft;
            categoryStyle.fontSize = 14;
            var scrollArea = new Rect(0, 0, position.width, position.height);
            scroll = GUI.BeginScrollView(scrollArea, scroll, view);
            var rect = position;
            rect.x = rect.y = 0;
            rect.height = 24;
            if (view.yMax > scrollArea.yMax)
                rect.width -= 16;

            foreach (var i in categories)
            {
                var selected = showCategory == i.Key;
                var oldSelected = selected;
                selected = GUI.Toggle(rect, selected, i.Key, categoryStyle);
                if (selected != oldSelected)
                    if (selected)
                    {
                        showCategory = i.Key;
                        UpdateSearchResults();
                    }
                    else
                    {
                        showCategory = "";
                        UpdateSearchResults();
                    }

                rect.y += rect.height + 3;
                if (showCategory == i.Key)
                    rect = DrawCategoryResults(rect);
            }
            GUI.EndScrollView();
            view = new Rect(0, 0, rect.xMax, rect.yMax);

        }

        protected Rect DrawCategoryResults(Rect rect)
        {

            var index = 0;
            var cc = GUI.contentColor;
            var style = new GUIStyle(GUI.skin.textField);
            style.hover.textColor = Color.blue;
            style.alignment = TextAnchor.MiddleLeft;
            style.fontStyle = FontStyle.Bold;
            style.imagePosition = ImagePosition.ImageLeft;
            style.hover.background = null;
            style.padding = new RectOffset(12, 2, 2, 2);
            foreach (var result in searchResults)
            {
                if (result.content == null)
                    result.content = new GUIContent(result.niceName + " " + result.signature, GetIcon(result.type));
                if (GUI.Button(rect, result.content, style))
                {
                    AddNodeToTarget(result, closeOnSuccess: false);
                }
                rect.y += rect.height + 2;
                index += 1;
            }
            GUI.contentColor = cc;
            return rect;
        }

    }

}
