﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProtoTable;
using System.IO;
using System;

namespace GameClient
{
    public class LocalSettingManager : Singleton<LocalSettingManager>
    {
        Dictionary<LocalSettingTable.eSetting, object> _localSetting = new Dictionary<LocalSettingTable.eSetting, object>();

        public T GetSetting<T>(LocalSettingTable.eSetting eSetting) where T : class, new()
        {
            if (!_localSetting.ContainsKey(eSetting))
            {
                var settingItem = TableManager.Instance().GetTableItem<ProtoTable.LocalSettingTable>((int)eSetting);
                if (null != settingItem)
                {
                    string filePath = getPersistentPath(settingItem.FilePath);
                    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
                    {
                        var content = File.ReadAllText(filePath);
                        if (!string.IsNullOrEmpty(content))
                        {
                            try
                            {
                                T setting = JsonUtility.FromJson<T>(content);
                                if (null != setting)
                                {
                                    _localSetting.Add(eSetting, setting);
                                    return setting;
                                }
                            }
                            catch (Exception e)
                            {
                                File.Delete(filePath);
                                LogManager.Instance().LogProcessFormat(15000, "read json file failed id = {0} name = {1} !!!", settingItem.ID,settingItem.FilePath);
                                LogManager.Instance().LogProcessFormat(15000,e.ToString());
                            }
                        }
                    }
                }
            }

            _localSetting.Add(eSetting, new T());

            return _localSetting[eSetting] as T;
        }

        public void SaveSettingToFile(LocalSettingTable.eSetting eSetting)
        {
            if(_localSetting.ContainsKey(eSetting))
            {
                var value = _localSetting[eSetting];
                if(null != value)
                {
                    var settingItem = TableManager.Instance().GetTableItem<ProtoTable.LocalSettingTable>((int)eSetting);
                    if(null != settingItem)
                    {
                        string content = JsonUtility.ToJson(value);
                        string filePath = getPersistentPath(settingItem.FilePath);
                        if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(content))
                        {
                            try
                            {
                                var path = Path.GetDirectoryName(filePath);
                                if(!Directory.Exists(path))
                                {
                                    Directory.CreateDirectory(path);
                                }
                                File.WriteAllText(filePath, content);
                            }
                            catch(Exception e)
                            {
                                LogManager.Instance().LogProcessFormat(15000, "save json file failed id = {0} name = {1}!!!", settingItem.ID,settingItem.FilePath);
                                LogManager.Instance().LogProcessFormat(15000,e.ToString());
                            }
                        }
                    }
                }
            }
        }

        private string getPersistentPath(string path)
        {
            if(!string.IsNullOrEmpty(path))
            {
                path = Application.persistentDataPath + path;
            }
            return path;
        }
    }
}