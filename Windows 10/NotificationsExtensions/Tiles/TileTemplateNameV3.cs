// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
//
// Copyright (c) Microsoft Corporation. All rights reserved

using System;
using System.Text;
#if !WINRT_NOT_PRESENT
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
#endif

namespace NotificationsExtensions
{
    internal enum TileTemplateNameV3
    {
        TileMedium,
        TileSmall,
        TileWide,
        TileLarge,

        TileSquare150x150Block
, TileSquare150x150Image
, TileSquare150x150PeekImageAndText01
, TileSquare150x150PeekImageAndText02
, TileSquare150x150PeekImageAndText03
, TileSquare150x150PeekImageAndText04
, TileSquare150x150Text01
, TileSquare150x150Text02
, TileSquare150x150Text03
, TileSquare150x150Text04
, TileSquare310x310BlockAndText01
, TileSquare310x310BlockAndText02
, TileSquare310x310Image
, TileSquare310x310ImageAndText01
, TileSquare310x310ImageAndText02
, TileSquare310x310ImageAndTextOverlay01
, TileSquare310x310ImageAndTextOverlay02
, TileSquare310x310ImageAndTextOverlay03
, TileSquare310x310ImageCollection
, TileSquare310x310ImageCollectionAndText01
, TileSquare310x310ImageCollectionAndText02
, TileSquare310x310SmallImagesAndTextList01
, TileSquare310x310SmallImagesAndTextList02
, TileSquare310x310SmallImagesAndTextList03
, TileSquare310x310SmallImagesAndTextList04
, TileSquare310x310Text01
, TileSquare310x310Text02
, TileSquare310x310Text03
, TileSquare310x310Text04
, TileSquare310x310Text05
, TileSquare310x310Text06
, TileSquare310x310Text07
, TileSquare310x310Text08
, TileSquare310x310TextList01
, TileSquare310x310TextList02
, TileSquare310x310TextList03
, TileWide310x150BlockAndText01
, TileWide310x150BlockAndText02
, TileWide310x150Image
, TileWide310x150ImageAndText01
, TileWide310x150ImageAndText02
, TileWide310x150ImageCollection
, TileWide310x150PeekImage01
, TileWide310x150PeekImage02
, TileWide310x150PeekImage03
, TileWide310x150PeekImage04
, TileWide310x150PeekImage05
, TileWide310x150PeekImage06
, TileWide310x150PeekImageAndText01
, TileWide310x150PeekImageAndText02
, TileWide310x150PeekImageCollection01
, TileWide310x150PeekImageCollection02
, TileWide310x150PeekImageCollection03
, TileWide310x150PeekImageCollection04
, TileWide310x150PeekImageCollection05
, TileWide310x150PeekImageCollection06
, TileWide310x150SmallImageAndText01
, TileWide310x150SmallImageAndText02
, TileWide310x150SmallImageAndText03
, TileWide310x150SmallImageAndText04
, TileWide310x150SmallImageAndText05
, TileWide310x150Text01
, TileWide310x150Text02
, TileWide310x150Text03
, TileWide310x150Text04
, TileWide310x150Text05
, TileWide310x150Text06
, TileWide310x150Text07
, TileWide310x150Text08
, TileWide310x150Text09
, TileWide310x150Text10
, TileWide310x150Text11,



        TileSquare71x71Image,
        TileSquare71x71IconWithBadge,
        TileSquare150x150IconWithBadge,
        TileWide310x150IconWithBadgeAndText


    }
}