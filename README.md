# BarbezDotEu.Vimeo

An unofficial, modern, very much work-in-progress client for Vimeo APIs.

## Contents

- [Connections](#T-BarbezDotEu-Vimeo-DTO-Connections 'BarbezDotEu.Vimeo.DTO.Connections')
  - [Albums](#P-BarbezDotEu-Vimeo-DTO-Connections-Albums 'BarbezDotEu.Vimeo.DTO.Connections.Albums')
  - [Appearances](#P-BarbezDotEu-Vimeo-DTO-Connections-Appearances 'BarbezDotEu.Vimeo.DTO.Connections.Appearances')
  - [Channels](#P-BarbezDotEu-Vimeo-DTO-Connections-Channels 'BarbezDotEu.Vimeo.DTO.Connections.Channels')
  - [Feed](#P-BarbezDotEu-Vimeo-DTO-Connections-Feed 'BarbezDotEu.Vimeo.DTO.Connections.Feed')
  - [FoldersRoot](#P-BarbezDotEu-Vimeo-DTO-Connections-FoldersRoot 'BarbezDotEu.Vimeo.DTO.Connections.FoldersRoot')
  - [Followers](#P-BarbezDotEu-Vimeo-DTO-Connections-Followers 'BarbezDotEu.Vimeo.DTO.Connections.Followers')
  - [Following](#P-BarbezDotEu-Vimeo-DTO-Connections-Following 'BarbezDotEu.Vimeo.DTO.Connections.Following')
  - [Groups](#P-BarbezDotEu-Vimeo-DTO-Connections-Groups 'BarbezDotEu.Vimeo.DTO.Connections.Groups')
  - [Likes](#P-BarbezDotEu-Vimeo-DTO-Connections-Likes 'BarbezDotEu.Vimeo.DTO.Connections.Likes')
  - [Membership](#P-BarbezDotEu-Vimeo-DTO-Connections-Membership 'BarbezDotEu.Vimeo.DTO.Connections.Membership')
  - [ModeratedChannels](#P-BarbezDotEu-Vimeo-DTO-Connections-ModeratedChannels 'BarbezDotEu.Vimeo.DTO.Connections.ModeratedChannels')
  - [Pictures](#P-BarbezDotEu-Vimeo-DTO-Connections-Pictures 'BarbezDotEu.Vimeo.DTO.Connections.Pictures')
  - [Portfolios](#P-BarbezDotEu-Vimeo-DTO-Connections-Portfolios 'BarbezDotEu.Vimeo.DTO.Connections.Portfolios')
  - [Shared](#P-BarbezDotEu-Vimeo-DTO-Connections-Shared 'BarbezDotEu.Vimeo.DTO.Connections.Shared')
  - [Teams](#P-BarbezDotEu-Vimeo-DTO-Connections-Teams 'BarbezDotEu.Vimeo.DTO.Connections.Teams')
  - [Videos](#P-BarbezDotEu-Vimeo-DTO-Connections-Videos 'BarbezDotEu.Vimeo.DTO.Connections.Videos')
- [GetUsersResponse](#T-BarbezDotEu-Vimeo-DTO-GetUsersResponse 'BarbezDotEu.Vimeo.DTO.GetUsersResponse')
  - [Page](#P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Page 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.Page')
  - [Paging](#P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Paging 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.Paging')
  - [PerPage](#P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-PerPage 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.PerPage')
  - [Total](#P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Total 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.Total')
  - [Users](#P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Users 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.Users')
  - [AsVideoHostingUsers()](#M-BarbezDotEu-Vimeo-DTO-GetUsersResponse-AsVideoHostingUsers 'BarbezDotEu.Vimeo.DTO.GetUsersResponse.AsVideoHostingUsers')
- [HttpQueryDefinition](#T-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition 'BarbezDotEu.Vimeo.DTO.HttpQueryDefinition')
  - [Total](#P-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition-Total 'BarbezDotEu.Vimeo.DTO.HttpQueryDefinition.Total')
  - [Uri](#P-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition-Uri 'BarbezDotEu.Vimeo.DTO.HttpQueryDefinition.Uri')
- [IVimeoDataProvider](#T-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider')
  - [Configure(configuration)](#M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-Configure-BarbezDotEu-Vimeo-VimeoConfiguration- 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider.Configure(BarbezDotEu.Vimeo.VimeoConfiguration)')
  - [GetUsersLike(usernames)](#M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetUsersLike-System-String[]- 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider.GetUsersLike(System.String[])')
  - [GetUsersLike(username)](#M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetUsersLike-System-String- 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider.GetUsersLike(System.String)')
  - [GetVideoHostingUsersLike(username)](#M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetVideoHostingUsersLike-System-String- 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider.GetVideoHostingUsersLike(System.String)')
- [LocationDetails](#T-BarbezDotEu-Vimeo-DTO-LocationDetails 'BarbezDotEu.Vimeo.DTO.LocationDetails')
  - [City](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-City 'BarbezDotEu.Vimeo.DTO.LocationDetails.City')
  - [Country](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-Country 'BarbezDotEu.Vimeo.DTO.LocationDetails.Country')
  - [CountryIsoCode](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-CountryIsoCode 'BarbezDotEu.Vimeo.DTO.LocationDetails.CountryIsoCode')
  - [FormattedAddress](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-FormattedAddress 'BarbezDotEu.Vimeo.DTO.LocationDetails.FormattedAddress')
  - [Latitude](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-Latitude 'BarbezDotEu.Vimeo.DTO.LocationDetails.Latitude')
  - [Longitude](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-Longitude 'BarbezDotEu.Vimeo.DTO.LocationDetails.Longitude')
  - [Neighborhood](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-Neighborhood 'BarbezDotEu.Vimeo.DTO.LocationDetails.Neighborhood')
  - [State](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-State 'BarbezDotEu.Vimeo.DTO.LocationDetails.State')
  - [StateIsoCode](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-StateIsoCode 'BarbezDotEu.Vimeo.DTO.LocationDetails.StateIsoCode')
  - [SubLocality](#P-BarbezDotEu-Vimeo-DTO-LocationDetails-SubLocality 'BarbezDotEu.Vimeo.DTO.LocationDetails.SubLocality')
- [MetaData](#T-BarbezDotEu-Vimeo-DTO-MetaData 'BarbezDotEu.Vimeo.DTO.MetaData')
  - [Connections](#P-BarbezDotEu-Vimeo-DTO-MetaData-Connections 'BarbezDotEu.Vimeo.DTO.MetaData.Connections')
- [Paging](#T-BarbezDotEu-Vimeo-DTO-Paging 'BarbezDotEu.Vimeo.DTO.Paging')
  - [First](#P-BarbezDotEu-Vimeo-DTO-Paging-First 'BarbezDotEu.Vimeo.DTO.Paging.First')
  - [Last](#P-BarbezDotEu-Vimeo-DTO-Paging-Last 'BarbezDotEu.Vimeo.DTO.Paging.Last')
  - [Next](#P-BarbezDotEu-Vimeo-DTO-Paging-Next 'BarbezDotEu.Vimeo.DTO.Paging.Next')
  - [Previous](#P-BarbezDotEu-Vimeo-DTO-Paging-Previous 'BarbezDotEu.Vimeo.DTO.Paging.Previous')
- [User](#T-BarbezDotEu-Vimeo-DTO-User 'BarbezDotEu.Vimeo.DTO.User')
  - [Bio](#P-BarbezDotEu-Vimeo-DTO-User-Bio 'BarbezDotEu.Vimeo.DTO.User.Bio')
  - [CreatedTime](#P-BarbezDotEu-Vimeo-DTO-User-CreatedTime 'BarbezDotEu.Vimeo.DTO.User.CreatedTime')
  - [Gender](#P-BarbezDotEu-Vimeo-DTO-User-Gender 'BarbezDotEu.Vimeo.DTO.User.Gender')
  - [Link](#P-BarbezDotEu-Vimeo-DTO-User-Link 'BarbezDotEu.Vimeo.DTO.User.Link')
  - [Location](#P-BarbezDotEu-Vimeo-DTO-User-Location 'BarbezDotEu.Vimeo.DTO.User.Location')
  - [LocationDetails](#P-BarbezDotEu-Vimeo-DTO-User-LocationDetails 'BarbezDotEu.Vimeo.DTO.User.LocationDetails')
  - [MetaData](#P-BarbezDotEu-Vimeo-DTO-User-MetaData 'BarbezDotEu.Vimeo.DTO.User.MetaData')
  - [Name](#P-BarbezDotEu-Vimeo-DTO-User-Name 'BarbezDotEu.Vimeo.DTO.User.Name')
  - [ShortBio](#P-BarbezDotEu-Vimeo-DTO-User-ShortBio 'BarbezDotEu.Vimeo.DTO.User.ShortBio')
  - [Uri](#P-BarbezDotEu-Vimeo-DTO-User-Uri 'BarbezDotEu.Vimeo.DTO.User.Uri')
  - [Websites](#P-BarbezDotEu-Vimeo-DTO-User-Websites 'BarbezDotEu.Vimeo.DTO.User.Websites')
- [VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration')
  - [#ctor(getUsersRootUrl,rateLimitPerMinute,bearerToken)](#M-BarbezDotEu-Vimeo-VimeoConfiguration-#ctor-System-String,System-String,System-String- 'BarbezDotEu.Vimeo.VimeoConfiguration.#ctor(System.String,System.String,System.String)')
  - [BearerToken](#P-BarbezDotEu-Vimeo-VimeoConfiguration-BearerToken 'BarbezDotEu.Vimeo.VimeoConfiguration.BearerToken')
  - [GetUsersRootUrl](#P-BarbezDotEu-Vimeo-VimeoConfiguration-GetUsersRootUrl 'BarbezDotEu.Vimeo.VimeoConfiguration.GetUsersRootUrl')
  - [RateLimitPerMinute](#P-BarbezDotEu-Vimeo-VimeoConfiguration-RateLimitPerMinute 'BarbezDotEu.Vimeo.VimeoConfiguration.RateLimitPerMinute')
- [VimeoDataProvider](#T-BarbezDotEu-Vimeo-VimeoDataProvider 'BarbezDotEu.Vimeo.VimeoDataProvider')
  - [#ctor(logger,httpClientFactory)](#M-BarbezDotEu-Vimeo-VimeoDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory- 'BarbezDotEu.Vimeo.VimeoDataProvider.#ctor(Microsoft.Extensions.Logging.ILogger,System.Net.Http.IHttpClientFactory)')
  - [Configuration](#P-BarbezDotEu-Vimeo-VimeoDataProvider-Configuration 'BarbezDotEu.Vimeo.VimeoDataProvider.Configuration')
  - [Configure()](#M-BarbezDotEu-Vimeo-VimeoDataProvider-Configure-BarbezDotEu-Vimeo-VimeoConfiguration- 'BarbezDotEu.Vimeo.VimeoDataProvider.Configure(BarbezDotEu.Vimeo.VimeoConfiguration)')
  - [GetUsersLike()](#M-BarbezDotEu-Vimeo-VimeoDataProvider-GetUsersLike-System-String[]- 'BarbezDotEu.Vimeo.VimeoDataProvider.GetUsersLike(System.String[])')
  - [GetUsersLike()](#M-BarbezDotEu-Vimeo-VimeoDataProvider-GetUsersLike-System-String- 'BarbezDotEu.Vimeo.VimeoDataProvider.GetUsersLike(System.String)')
  - [GetVideoHostingUsersLike()](#M-BarbezDotEu-Vimeo-VimeoDataProvider-GetVideoHostingUsersLike-System-String- 'BarbezDotEu.Vimeo.VimeoDataProvider.GetVideoHostingUsersLike(System.String)')
- [Website](#T-BarbezDotEu-Vimeo-DTO-Website 'BarbezDotEu.Vimeo.DTO.Website')
  - [Description](#P-BarbezDotEu-Vimeo-DTO-Website-Description 'BarbezDotEu.Vimeo.DTO.Website.Description')
  - [Link](#P-BarbezDotEu-Vimeo-DTO-Website-Link 'BarbezDotEu.Vimeo.DTO.Website.Link')
  - [Name](#P-BarbezDotEu-Vimeo-DTO-Website-Name 'BarbezDotEu.Vimeo.DTO.Website.Name')
  - [Type](#P-BarbezDotEu-Vimeo-DTO-Website-Type 'BarbezDotEu.Vimeo.DTO.Website.Type')
  - [Uri](#P-BarbezDotEu-Vimeo-DTO-Website-Uri 'BarbezDotEu.Vimeo.DTO.Website.Uri')
  - [AsWebsiteData()](#M-BarbezDotEu-Vimeo-DTO-Website-AsWebsiteData 'BarbezDotEu.Vimeo.DTO.Website.AsWebsiteData')

<a name='T-BarbezDotEu-Vimeo-DTO-Connections'></a>
## Connections `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements connections according to the contract defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Albums'></a>
### Albums `property`

##### Summary

Gets or sets the albums.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Appearances'></a>
### Appearances `property`

##### Summary

Gets or sets the appearances.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Channels'></a>
### Channels `property`

##### Summary

Gets or sets the channels.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Feed'></a>
### Feed `property`

##### Summary

Gets or sets the feed.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-FoldersRoot'></a>
### FoldersRoot `property`

##### Summary

Gets or sets the folders root.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Followers'></a>
### Followers `property`

##### Summary

Gets or sets the followers.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Following'></a>
### Following `property`

##### Summary

Gets or sets the following.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Groups'></a>
### Groups `property`

##### Summary

Gets or sets the groups.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Likes'></a>
### Likes `property`

##### Summary

Gets or sets the likes.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Membership'></a>
### Membership `property`

##### Summary

Gets or sets the membership.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-ModeratedChannels'></a>
### ModeratedChannels `property`

##### Summary

Gets or sets the moderated channels.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Pictures'></a>
### Pictures `property`

##### Summary

Gets or sets the pictures.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Portfolios'></a>
### Portfolios `property`

##### Summary

Gets or sets the portfolios.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Shared'></a>
### Shared `property`

##### Summary

Gets or sets the shared [HttpQueryDefinition](#T-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition 'BarbezDotEu.Vimeo.DTO.HttpQueryDefinition').

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Teams'></a>
### Teams `property`

##### Summary

Gets or sets the teams.

<a name='P-BarbezDotEu-Vimeo-DTO-Connections-Videos'></a>
### Videos `property`

##### Summary

Gets or sets the videos.

<a name='T-BarbezDotEu-Vimeo-DTO-GetUsersResponse'></a>
## GetUsersResponse `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements the query response contract as defined by Vimeo after querying for users.

<a name='P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Page'></a>
### Page `property`

##### Summary

Gets or sets the current page of results.

<a name='P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Paging'></a>
### Paging `property`

##### Summary

Gets or sets the paging information.

<a name='P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-PerPage'></a>
### PerPage `property`

##### Summary

Gets or sets the number of results per page.

<a name='P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Total'></a>
### Total `property`

##### Summary

Gets or sets the total number of results.

<a name='P-BarbezDotEu-Vimeo-DTO-GetUsersResponse-Users'></a>
### Users `property`

##### Summary

Gets or sets the resulting set of [User](#T-BarbezDotEu-Vimeo-DTO-User 'BarbezDotEu.Vimeo.DTO.User')s.

<a name='M-BarbezDotEu-Vimeo-DTO-GetUsersResponse-AsVideoHostingUsers'></a>
### AsVideoHostingUsers() `method`

##### Summary

Returns this [GetUsersResponse](#T-BarbezDotEu-Vimeo-DTO-GetUsersResponse 'BarbezDotEu.Vimeo.DTO.GetUsersResponse') as collection of [VideoHostingUser](#T-BarbezDotEu-VideoHost-DTO-VideoHostingUser 'BarbezDotEu.VideoHost.DTO.VideoHostingUser')s.

##### Returns

This [GetUsersResponse](#T-BarbezDotEu-Vimeo-DTO-GetUsersResponse 'BarbezDotEu.Vimeo.DTO.GetUsersResponse') as collection of [VideoHostingUser](#T-BarbezDotEu-VideoHost-DTO-VideoHostingUser 'BarbezDotEu.VideoHost.DTO.VideoHostingUser')s.

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition'></a>
## HttpQueryDefinition `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements a [HttpQueryDefinition](#T-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition 'BarbezDotEu.Vimeo.DTO.HttpQueryDefinition') as outlined in the contract defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition-Total'></a>
### Total `property`

##### Summary

Gets or sets the total results to expect when executing the HTTP query.

<a name='P-BarbezDotEu-Vimeo-DTO-HttpQueryDefinition-Uri'></a>
### Uri `property`

##### Summary

The URI to the HTTP query.

<a name='T-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider'></a>
## IVimeoDataProvider `type`

##### Namespace

BarbezDotEu.Vimeo.Interfaces

##### Summary

Defines a blueprint for a data provider that connects to and can call Vimeo.com APIs.

<a name='M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-Configure-BarbezDotEu-Vimeo-VimeoConfiguration-'></a>
### Configure(configuration) `method`

##### Summary

Configures this [IVimeoDataProvider](#T-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider') so that it can successfully communicate with the Vimeo.com APIs.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [BarbezDotEu.Vimeo.VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration') | The [VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration') to configure this [IVimeoDataProvider](#T-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider 'BarbezDotEu.Vimeo.Interfaces.IVimeoDataProvider') with. |

##### Remarks

Configuration is required before any APIs can be called.

<a name='M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetUsersLike-System-String[]-'></a>
### GetUsersLike(usernames) `method`

##### Summary

Queries for occurences of users on the video hosting platform likely to correspond to the given list of usernames.

##### Returns

A plausible list of video hosting platform users corresponding to the give list of usernames.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| usernames | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The users for whom to return likely accounts for. |

<a name='M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetUsersLike-System-String-'></a>
### GetUsersLike(username) `method`

##### Summary

Queries for occurences of users on the video hosting platform likely to correspond to a given username.

##### Returns

A plausible list of video hosting platform users corresponding to a given username.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user for whom to return likely accounts for. |

<a name='M-BarbezDotEu-Vimeo-Interfaces-IVimeoDataProvider-GetVideoHostingUsersLike-System-String-'></a>
### GetVideoHostingUsersLike(username) `method`

##### Summary

Queries for occurences of users on the video hosting platform likely to correspond to a given username.

##### Returns

A plausible list of video hosting platform users corresponding to a given username.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| username | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user for whom to return likely accounts for. |

<a name='T-BarbezDotEu-Vimeo-DTO-LocationDetails'></a>
## LocationDetails `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements a location details object according to the interface defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-City'></a>
### City `property`

##### Summary

Gets or sets the city.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-Country'></a>
### Country `property`

##### Summary

Gets or sets the country.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-CountryIsoCode'></a>
### CountryIsoCode `property`

##### Summary

Gets or sets the country ISO code.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-FormattedAddress'></a>
### FormattedAddress `property`

##### Summary

Gets or sets the formatted address.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-Latitude'></a>
### Latitude `property`

##### Summary

Gets or sets the latitude.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-Longitude'></a>
### Longitude `property`

##### Summary

Gets or sets the longitude.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-Neighborhood'></a>
### Neighborhood `property`

##### Summary

Gets or sets the neighborhood.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-State'></a>
### State `property`

##### Summary

Gets or sets the state.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-StateIsoCode'></a>
### StateIsoCode `property`

##### Summary

Gets or sets the state ISO code.

<a name='P-BarbezDotEu-Vimeo-DTO-LocationDetails-SubLocality'></a>
### SubLocality `property`

##### Summary

Gets or sets the sub locality.

<a name='T-BarbezDotEu-Vimeo-DTO-MetaData'></a>
## MetaData `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements a metadata object according to the interface defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-MetaData-Connections'></a>
### Connections `property`

##### Summary

Gets or sets the connections.

<a name='T-BarbezDotEu-Vimeo-DTO-Paging'></a>
## Paging `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements the Vimeo paging object according to the contract defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-Paging-First'></a>
### First `property`

##### Summary

Relative URL pointing to the first page.

<a name='P-BarbezDotEu-Vimeo-DTO-Paging-Last'></a>
### Last `property`

##### Summary

Relative URL pointing to the last page.

<a name='P-BarbezDotEu-Vimeo-DTO-Paging-Next'></a>
### Next `property`

##### Summary

Relative URL pointing to the next page.

<a name='P-BarbezDotEu-Vimeo-DTO-Paging-Previous'></a>
### Previous `property`

##### Summary

Relative URL pointing to the previous page.

<a name='T-BarbezDotEu-Vimeo-DTO-User'></a>
## User `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements a user according to the contract defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Bio'></a>
### Bio `property`

##### Summary

Gets or sets the bio.

<a name='P-BarbezDotEu-Vimeo-DTO-User-CreatedTime'></a>
### CreatedTime `property`

##### Summary

Gets or sets the created time.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Gender'></a>
### Gender `property`

##### Summary

Gets or sets the gender.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Link'></a>
### Link `property`

##### Summary

Gets or sets an absolute URL, potentially an URL directing away from Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Location'></a>
### Location `property`

##### Summary

Gets or sets the location.

<a name='P-BarbezDotEu-Vimeo-DTO-User-LocationDetails'></a>
### LocationDetails `property`

##### Summary

Gets or sets the

<a name='P-BarbezDotEu-Vimeo-DTO-User-MetaData'></a>
### MetaData `property`

##### Summary

Gets or sets the

<a name='P-BarbezDotEu-Vimeo-DTO-User-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='P-BarbezDotEu-Vimeo-DTO-User-ShortBio'></a>
### ShortBio `property`

##### Summary

Gets or sets the short bio.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Uri'></a>
### Uri `property`

##### Summary

Gets or sets a relative Vimeo URL for the user.

<a name='P-BarbezDotEu-Vimeo-DTO-User-Websites'></a>
### Websites `property`

##### Summary

Gets or sets the websites.

<a name='T-BarbezDotEu-Vimeo-VimeoConfiguration'></a>
## VimeoConfiguration `type`

##### Namespace

BarbezDotEu.Vimeo

##### Summary

Implements and houses configuration parameters to correctly connect to and communicate with Vimeo.com's services.

<a name='M-BarbezDotEu-Vimeo-VimeoConfiguration-#ctor-System-String,System-String,System-String-'></a>
### #ctor(getUsersRootUrl,rateLimitPerMinute,bearerToken) `constructor`

##### Summary

Constructs a [VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| getUsersRootUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The root URL for querying user information (without actual user info). |
| rateLimitPerMinute | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The maximum number of requests per minute. |
| bearerToken | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A bearer token to be used in the authentication header for requests. |

<a name='P-BarbezDotEu-Vimeo-VimeoConfiguration-BearerToken'></a>
### BearerToken `property`

##### Summary

Gets a bearer token to be used in the authentication header for requests.

<a name='P-BarbezDotEu-Vimeo-VimeoConfiguration-GetUsersRootUrl'></a>
### GetUsersRootUrl `property`

##### Summary

Gets the root URL for querying user information (without actual user info).

<a name='P-BarbezDotEu-Vimeo-VimeoConfiguration-RateLimitPerMinute'></a>
### RateLimitPerMinute `property`

##### Summary

Gets the maximum number of requests per minute.

<a name='T-BarbezDotEu-Vimeo-VimeoDataProvider'></a>
## VimeoDataProvider `type`

##### Namespace

BarbezDotEu.Vimeo

##### Summary

Implements a data provider that connects to and can call Vimeo.com APIs.

<a name='M-BarbezDotEu-Vimeo-VimeoDataProvider-#ctor-Microsoft-Extensions-Logging-ILogger,System-Net-Http-IHttpClientFactory-'></a>
### #ctor(logger,httpClientFactory) `constructor`

##### Summary

Constructs a new [VimeoDataProvider](#T-BarbezDotEu-Vimeo-VimeoDataProvider 'BarbezDotEu.Vimeo.VimeoDataProvider').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Microsoft.Extensions.Logging.ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') | A [ILogger](#T-Microsoft-Extensions-Logging-ILogger 'Microsoft.Extensions.Logging.ILogger') to use for logging. |
| httpClientFactory | [System.Net.Http.IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') | The [IHttpClientFactory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.IHttpClientFactory 'System.Net.Http.IHttpClientFactory') to use. |

<a name='P-BarbezDotEu-Vimeo-VimeoDataProvider-Configuration'></a>
### Configuration `property`

##### Summary

Gets the [VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration') this [VimeoConfiguration](#T-BarbezDotEu-Vimeo-VimeoConfiguration 'BarbezDotEu.Vimeo.VimeoConfiguration') uses to communicate to the APIs.

<a name='M-BarbezDotEu-Vimeo-VimeoDataProvider-Configure-BarbezDotEu-Vimeo-VimeoConfiguration-'></a>
### Configure() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Vimeo-VimeoDataProvider-GetUsersLike-System-String[]-'></a>
### GetUsersLike() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Vimeo-VimeoDataProvider-GetUsersLike-System-String-'></a>
### GetUsersLike() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-BarbezDotEu-Vimeo-VimeoDataProvider-GetVideoHostingUsersLike-System-String-'></a>
### GetVideoHostingUsersLike() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-BarbezDotEu-Vimeo-DTO-Website'></a>
## Website `type`

##### Namespace

BarbezDotEu.Vimeo.DTO

##### Summary

Implements a website according to the contract as defined by Vimeo.

<a name='P-BarbezDotEu-Vimeo-DTO-Website-Description'></a>
### Description `property`

##### Summary

Gets or sets the description.

<a name='P-BarbezDotEu-Vimeo-DTO-Website-Link'></a>
### Link `property`

##### Summary

Gets or sets the link.

<a name='P-BarbezDotEu-Vimeo-DTO-Website-Name'></a>
### Name `property`

##### Summary

Gets or sets the name.

<a name='P-BarbezDotEu-Vimeo-DTO-Website-Type'></a>
### Type `property`

##### Summary

Gets or sets the type.

<a name='P-BarbezDotEu-Vimeo-DTO-Website-Uri'></a>
### Uri `property`

##### Summary

Gets or sets the URL

<a name='M-BarbezDotEu-Vimeo-DTO-Website-AsWebsiteData'></a>
### AsWebsiteData() `method`

##### Summary

Returns this object as a [WebsiteData](#T-BarbezDotEu-VideoHost-DTO-WebsiteData 'BarbezDotEu.VideoHost.DTO.WebsiteData') DTO.

##### Returns

This object as a [WebsiteData](#T-BarbezDotEu-VideoHost-DTO-WebsiteData 'BarbezDotEu.VideoHost.DTO.WebsiteData') DTO.

##### Parameters

This method has no parameters.
