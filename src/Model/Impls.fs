namespace Quest.Model

module Clue =
    let create question image answers = {
        question = question
        image = image
        answers = answers
    }

module Quest =
    let create name image clues = {
        name = name
        image = image
        clues = clues
    }

module Player =
    let create name = {
        name = name
    }

module Team =
    let add (player:Player) team = {
        team with players = team.players |> Set.add player
    }

    let remove (player:Player) team = {
        team with players = team.players |> Set.remove player
    }

    let has (player:Player) team =
        team |> List.contains player

    let create name = {
        name = name
        players = Set.empty
    }

module Game =
    let create quest = {
        quest = quest
        teams = Set.empty
        state = NotStarted
    }

    let add team game = {
        game with teams = game.teams |> Set.add team
    }

    let remove team game = {
        game with teams = game.teams |> Set.remove team
    }

    let reset game = {
        game with state = NotStarted
    }

    type InitialClueFor = Team -> Game -> Clue
    type CurrentClueFor = Team -> Game -> Clue
