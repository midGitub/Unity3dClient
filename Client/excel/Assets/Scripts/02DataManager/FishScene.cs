﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameClient
{
    public class FishSprite
    {
        public int kind_id;
        public GameObject self;
        public ComSpriteItems action;
    }
    public class FishScene
    {
        static List<FishSprite>[] mFishPools = null;

        public static void throwFishToPool(FishSprite fish)
        {
            if(null == fish)
            {
                return;
            }

            int iIndex = (int)fish.kind_id - 1;
            if (iIndex >= 0 && iIndex < mFishPools.Length)
            {
                if (null != mFishPools[iIndex])
                {
                    mFishPools[iIndex].Add(fish);
                    return;
                }
            }
            LogManager.Instance().LogErrorFormat("<color=#ff0000>throw fish to pool failed kind_id = {0} !!!</color>", fish.kind_id);
        }

        public static FishSprite createFishFromPool(int kind_id)
        {
            int iIndex = (int)kind_id - 1;
            if (iIndex >= 0 && iIndex < mFishPools.Length)
            {
                if(null != mFishPools[iIndex])
                {
                    var pool = mFishPools[iIndex];
                    if(pool.Count > 0)
                    {
                        var fish = pool[0];
                        pool.RemoveAt(0);
                        return fish;
                    }
                }
            }

            LogManager.Instance().LogErrorFormat("<color=#ff0000>create fish from pool failed kind_id = {0} !!!</color>", kind_id);
            return null;
        }

        public static IScene CreateFishScene()
        {
            Scene scene = new Scene();
            scene.onBeginLoading = _OnBeginLoading;
            scene.onEndLoading = _OnEndLoading;
            scene.onRunning = null;
            scene.itExit = null;
            scene.itEnter = _OnLoadResources(scene);
            scene.onEnter = _OnEnter;
            scene.onExit = _OnExit;
            return scene;
        }

        static void _OnBeginLoading()
        {
            UIManager.Instance().OpenFrame<LoadingFrame>(7);
        }

        static void _OnEndLoading()
        {
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_FINISH);
        }

        static IEnumerator _OnLoadResources(Scene scene)
        {
            if(null == scene)
            {
                scene.SetAction(SceneAction.SA_INVALID);
                yield break;
            }
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_TITLE, "加载鱼的资源...");
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_PROCESS, 0.0f);
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_SUB_PROCESS, 0.0f);
            var table = TableManager.Instance().GetTable(typeof(ProtoTable.FishTable));
            if(null == table)
            {
                LogManager.Instance().LogErrorFormat("get FishTable failed !!!");
                scene.SetAction(SceneAction.SA_INVALID);
                yield break;
            }
            var enumerator = table.GetEnumerator();
            if (null == mFishPools)
            {
                mFishPools = new List<FishSprite>[table.Count];
            }
            int i = 1;
            while(enumerator.MoveNext())
            {
                var fishItem = enumerator.Current.Value as ProtoTable.FishTable;
                int iIndex = i - 1;
                if(null == mFishPools[iIndex])
                {
                    mFishPools[iIndex] = new List<FishSprite>(16);
                }
                var fishPool = mFishPools[iIndex];

                for(int j = 0; j < FishConfig.fish_pre_load_count; ++j)
                {
                    if (fishPool.Count <= 0)
                    {
                        GameObject goFish = AssetLoader.Instance().LoadRes(fishItem.Prefab, typeof(GameObject)).obj as GameObject;
                        if (null == goFish)
                        {
                            LogManager.Instance().LogErrorFormat("can not create fish first frame res is null ! resId = {0} name = {1}", fishItem.ID, fishItem.Desc);
                            scene.SetAction(SceneAction.SA_INVALID);
                            yield break;
                        }
                        ComSpriteItems sprite = goFish.GetComponent<ComSpriteItems>();
                        if (null == sprite)
                        {
                            LogManager.Instance().LogErrorFormat("can not create fish first frame ComSpriteItems is null ! resId = {0} name = {1}", fishItem.ID, fishItem.Desc);
                            scene.SetAction(SceneAction.SA_INVALID);
                            yield break;
                        }
                        goFish.CustomActive(false);
                        fishPool.Add(new FishSprite {kind_id = fishItem.ID,self = goFish, action = sprite });
                    }
                    else
                    {
                        GameObject goFish = GameObject.Instantiate(fishPool[0].self) as GameObject;
                        ComSpriteItems sprite = goFish.GetComponent<ComSpriteItems>();
                        if (null == sprite)
                        {
                            LogManager.Instance().LogErrorFormat("can not create fish first frame ComSpriteItems is null ! resId = {0} name = {1}", fishItem.ID, fishItem.Desc);
                            scene.SetAction(SceneAction.SA_INVALID);
                            yield break;
                        }
                        goFish.CustomActive(false);
                        fishPool.Add(new FishSprite { kind_id = fishItem.ID, self = goFish, action = sprite });
                    }
                }

                EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_SUB_TITLE, string.Format("加载鱼...{0}/{1}", i, table.Count));
                float fRadio = i * 1.0f / table.Count;
                EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_SUB_PROCESS, fRadio);
                EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_PROCESS, 0.98f * fRadio);
                ++i;
                yield return new WaitForEndOfFrame();
            }

            yield return new WaitForEndOfFrame();
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_PROCESS, 0.98f);
            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_TITLE, "加载场景音乐...");
            AudioManager.Instance().PlaySound(1001);

            EventManager.Instance().SendEvent(ClientEvent.CE_ON_SET_LOADING_PROCESS, 1.0f);
            yield return new WaitForEndOfFrame();
            if (null != scene)
            {
                scene.SetAction(SceneAction.SA_READY_RUNNING);
            }
        }

        static void _OnEnter()
        {
            UIManager.Instance().OpenFrame<FishMainFrame>(5);
        }

        static void _OnExit()
        {
            if(null != mFishPools)
            {
                for(int i = 0; i < mFishPools.Length; ++i)
                {
                    var pool = mFishPools[i];
                    if(null != pool)
                    {
                        pool.Clear();
                    }
                    mFishPools[i] = null;
                }
                mFishPools = null;
            }
        }
    }
}