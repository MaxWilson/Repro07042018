module App

open Elmish

open Fable
open Fable.Core.JsInterop
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.PowerPack
open Fable.Recharts
open Fable.Recharts.Props

open Fulma
open Fulma.Layouts
open Fulma.Elements
open Fulma.Elements.Form
open Fulma.Extra.FontAwesome
open Fulma.Components
open Fulma.BulmaClasses
open Froggy
open Froggy.Dnd5e
open Shared
open Froggy.Dnd5e.CharGen
open Froggy.Common
open Froggy.Packrat
open ViewHelpers

/// The overall data model driving the view.
type Model =
    { Input: string
      Output: string
      GameState: Data.State }

/// The different types of messages in the system.
type Msg =
    | InputChanged of string
    | OutputChanged of string
    | ExecuteCommand of string

/// The init function is called to start the message pump with an initial view.
let init () =
    { Input = "";
    Output = "";
    GameState = Data.State.Empty
    }
      , Cmd.ofMsg(ExecuteCommand "rollstats")

let random = System.Random()
let roll = Data.resolve <| fun x -> 1 + random.Next(x)
let io: (IO<_>) = { load = (thunk1 failwith "Not implemented"); save = thunk2 failwith "Not implemented" }
/// The update function knows how to update the model given a message.
let update msg model =
    match msg with
    | InputChanged msg -> { model with Input = msg }, Cmd.none
    | OutputChanged msg -> { model with Output = msg }, Cmd.none
    | ExecuteCommand cmd ->
      let cmds = CharGen.parse (ParseContext.Init cmd)
      let state = CharGen.update io roll cmds model.GameState
      { model with Output = CharGen.view state; GameState = state }, Cmd.none

//[<AutoOpen>]
//module ViewParts =
//    let basicTile title options content =
//        Tile.tile options [
//            Notification.notification [ Notification.Props [ Style [ Height "100%"; Width "100%" ] ] ]
//                (Heading.h2 [] [ str title ] :: content)
//        ]
//    let childTile title content =
//        Tile.child [ ] [
//            Notification.notification [ Notification.Props [ Style [ Height "100%"; Width "100%" ] ] ]
//                (Heading.h2 [ ] [ str title ] :: content)
//        ]

//    let crimeTile crimes =
//        let cleanData = crimes |> Array.map (fun c -> { c with Crime = c.Crime.[0..0].ToUpper() + c.Crime.[1..].Replace('-', ' ') } )
//        basicTile "Crime" [ ] [
//            barChart
//                [ Chart.Data cleanData
//                  Chart.Width 600.
//                  Chart.Height 500.
//                  Chart.Layout Vertical ]
//                [ xaxis [ Cartesian.Type "number" ] []
//                  yaxis [ Cartesian.Type "category"; Cartesian.DataKey "Crime"; Cartesian.Width 200. ] []
//                  bar [ Cartesian.DataKey "Incidents" ] [] ]
//        ]

//    let getBingMapUrl latLong =
//        sprintf "https://www.bing.com/maps/embed?h=400&w=800&cp=%f~%f&lvl=11&typ=s&FORM=MBEDV8" latLong.Latitude latLong.Longitude

//    let bingMapTile (latLong:LatLong) =
//        basicTile "Map" [ Tile.Size Tile.Is12 ] [
//            iframe [
//                Style [ Height 410; Width 810 ]
//                (* Task 3.1 MAPS: Use the getBingMapUrl function to build a valid maps URL using the supplied LatLong.
//                   You can use it to add a Src attribute to this iframe. *)
//            ] [ ]
//        ]

//    let weatherTile weatherReport =
//        childTile "Weather" [
//            Level.level [ ] [
//                Level.item [ Level.Item.HasTextCentered ] [
//                    div [ ] [
//                        Level.heading [ ] [
//                            Image.image [ Image.Is128x128 ] [
//                                img [ Src(sprintf "https://www.metaweather.com/static/img/weather/%s.svg" weatherReport.WeatherType.Abbreviation) ]
//                            ]
//                        ]
//                        Level.title [ ] [
//                            Heading.h3 [ Heading.Is4; Heading.Props [ Style [ Width "100%" ] ] ] [
//                                (* Task 4.4 WEATHER: Get the temperature from the given weather report
//                                   and display it here instead of an empty string. *)
//                                str ""
//                            ]
//                        ]
//                    ]
//                ]
//            ]
//        ]
//    let locationTile model =
//        childTile "Location" [
//            div [ ] [
//                Heading.h3 [ ] [ str "model.Location.Location.Town" ]
//                Heading.h4 [ ] [ str "model.Location.Location.Region" ]
//                Heading.h4 [ ] [ """sprintf "%.1fKM to London" model.Location.DistanceToLondon""" |> str ]
//            ]
//        ]


/// The view function knows how to render the UI given a model, as well as to dispatch new messages based on user actions.
let view (model:Model) dispatch =
    div [] [
        Navbar.navbar [ Navbar.Color IsPrimary ] [
            Navbar.Item.div [] [
                Heading.h1 [] [ str "Location Review!" ] ]
            ]

        Container.container [] [
            yield
                Field.div [] [
                    Label.label [] [ str "Input" ]
                    Control.div [ Control.HasIconLeft; Control.HasIconRight ] [
                        Input.text
                            [ Input.Placeholder "Ex: rollstats"
                              Input.Value model.Input
                              Input.Color (if (model:Model).GameState.Current.IsSome then Color.IsDanger else Color.IsSuccess)
                              Input.Props [ OnChange (fun ev -> dispatch (InputChanged !!ev.target?value)); onKeyDown KeyCode.enter (fun _ -> dispatch <| (ExecuteCommand model.Input)) ] ]
                        Icon.faIcon [ Icon.Size IsSmall; Icon.IsLeft ] [ Fa.icon Fa.I.Building ]
                        (match model with
                         | { GameState = { Current = Some _ } } -> Icon.faIcon [ Icon.Size IsSmall; Icon.IsRight ] [ Fa.icon Fa.I.Exclamation ]
                         | _ -> Icon.faIcon [ Icon.Size IsSmall; Icon.IsRight ] [ Fa.icon Fa.I.Check ])
                    ]
                    Help.help
                       [ Help.Color (if model.GameState.Current.IsNone then IsSuccess else IsDanger) ]
                       [ str (match model.GameState.Current with Some(v) -> model.GameState.Party.[v].Name | _ -> "") ]
                ]
            yield
                Field.div [ Field.IsGrouped ] [
                    Level.level [ ] [
                        Level.left [] [
                            Level.item [] [
                                Button.button
                                    [ Button.IsFullwidth
                                      Button.Color IsPrimary
                                      Button.OnClick (fun _ -> dispatch (ExecuteCommand model.Input))
                                      //Button.Disabled (model.ValidationError.IsSome)
                                      //Button.IsLoading (model.ServerState = ServerState.Loading)
                                      ]
                                    [ str "Submit" ] ] ] ]

                ]

            match model with
            | { Output = "" } -> ()
            | { Output = lines } ->
                for line in lines.Split('\n') do
                  yield div [] [str line]
                //yield
                //    Tile.ancestor [ ] [
                //        Tile.parent [ Tile.Size Tile.Is12 ] [
                //            bingMapTile model.Location.Location.LatLong
                //        ]
                //    ]
                //yield
                //    Tile.ancestor [ ] [
                //        Tile.parent [ Tile.IsVertical; Tile.Size Tile.Is4 ] [
                //            locationTile model
                //            (* Task 4.6 WEATHER: Generate the view code for the weather tile
                //               using the weatherTile function, supplying the weather report
                //               from the model, and include it here as part of the list *)
                //        ]
                //        Tile.parent [ Tile.Size Tile.Is8 ] [
                //            crimeTile model.Crimes
                //        ]
                //  ]
        ]

        br [ ]

        Footer.footer [] [
            Content.content
                [ Content.CustomClass Bulma.Properties.Alignment.HasTextCentered ]
                [ ]
        ]
    ]
