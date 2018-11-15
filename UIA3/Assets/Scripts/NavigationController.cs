using UnityEngine;

public class NavigationController : MonoBehaviour {

	// content objects
	public GameObject LoginContent;
	public GameObject NewsFeedContent;
	public GameObject SearchListContent;
	public GameObject LibraryContent;
	public GameObject FollowingContent;
	public GameObject FollowersFeed;
	public GameObject PlaylistFeed;
	public GameObject PlaylistDetailFeed;
	public GameObject ArtistContent;
	public GameObject SettingsContent;

	// bottom objects
	public GameObject NavBar;
	public GameObject MiniPlayer;

	// top objects
	public GameObject HomeTitle;
	public GameObject SearchTitle;
	public GameObject LibraryTitle;
	public GameObject FollowingTitle;
	public GameObject FollowersTitle;
	public GameObject PlaylistsTitle;
	public GameObject PlaylistDetailTitle;
	public GameObject ArtistTitle;
	public GameObject SettingsTitle;

	private void SetTop(GameObject top)
	{
		HomeTitle.SetActive(false);
		SearchTitle.SetActive(false);
		LibraryTitle.SetActive(false);
		FollowingTitle.SetActive(false);
		FollowersTitle.SetActive(false);
		PlaylistsTitle.SetActive(false);
		PlaylistDetailTitle.SetActive(false);
		ArtistTitle.SetActive(false);
		SettingsContent.SetActive(false);
		if (top != null)
		{
			top.SetActive(true);
		}
	}

	private void SetContent(GameObject content)
	{
		LoginContent.SetActive(false);
		NewsFeedContent.SetActive(false);
		SearchListContent.SetActive(false);
		LibraryContent.SetActive(false);
		FollowingContent.SetActive(false);
		FollowersFeed.SetActive(false);
		PlaylistFeed.SetActive(false);
		PlaylistDetailFeed.SetActive(false);
		ArtistContent.SetActive(false);
		SettingsContent.SetActive(false);
		if (content != null)
		{
			content.SetActive(true);
		}
	}

	private void ShowBottom()
	{
		NavBar.SetActive(true);
		MiniPlayer.SetActive(true);
	}

	private void HideBottom()
	{
		NavBar.SetActive(false);
		MiniPlayer.SetActive(false);
	}

	public void GoToLogin()
	{
		SetContent(LoginContent);
		SetTop(null);
		HideBottom();
	}

	public void GoToHome()
	{
		SetContent(NewsFeedContent);
		SetTop(HomeTitle);
		ShowBottom();
	}

	public void GoToSearch()
	{
		SetContent(SearchListContent);
		SetTop(SearchTitle);
		ShowBottom();
	}

	public void GoToLibrary()
	{
		SetContent(LibraryContent);
		SetTop(LibraryTitle);
		ShowBottom();
	}

	public void GoToFollowing()
	{
		SetContent(FollowingContent);
		SetTop(FollowingTitle);
		ShowBottom();
	}

	public void GoToFollowers()
	{
		SetContent(FollowersFeed);
		SetTop(FollowersTitle);
		ShowBottom();
	}

	public void GoToPlaylists()
	{
		SetContent(PlaylistFeed);
		SetTop(PlaylistsTitle);
		ShowBottom();
	}

	public void GoToPlaylistDetail()
	{
		SetContent(PlaylistDetailFeed);
		SetTop(PlaylistDetailTitle);
		ShowBottom();
	}

	public void GoToArtist()
	{
		SetContent(ArtistContent);
		SetTop(ArtistTitle);
		ShowBottom();
	}

	public void GoToSettings()
	{
		SetContent(SettingsContent);
		SetTop(SettingsTitle);
		ShowBottom();
	}
}
