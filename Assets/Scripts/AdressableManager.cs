using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class AdressableManager : MonoBehaviour
{
	private const string AWSRegionURL = "https://s3.ap-northeast-2.amazonaws.com";
	private const string _bucketName = "yafit-dev-resources";
	private string _bundlePath;
	private string _loadKey;
	private string _appVersion;

	private void Init()
	{
		_bundlePath = string.Format("{0}/AdressableData", Application.persistentDataPath);

	}
}
