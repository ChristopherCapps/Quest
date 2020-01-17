namespace Quest.Model

module Quest =

    module Clue =
        type Question = string
        type Answer = string

        type Image = Image

        type T = {
            question: Question
            image: Image option
            answers: Answer list
        }

        let make question image answers = {
            question = question
            image = image
            answers = answers
        }

    type Image = Image
    type Clue = Clue.T

    type ClueSequencing =
        | Ordered
        | Random

    type T = {
        name: string
        image: Image option
        clues: Clue list
        sequencing: ClueSequencing
    }

module Game =

    module Player =
        type T = {
            name: string
        }

        let make name = {
            name = name
        }

    module Team =
        type Player = Player.T

        type T = {
            name: string
            players: Player list
        }

        let add (player:Player) team = {
            team with players = player :: team.players
        }

        let remove (player:Player) team = {
            team with players = team.players |> List.except (seq { yield player })
        }

        let has (player:Player) team =
            team |> List.contains player

        let make name = {
            name = name
            players = []
        }

