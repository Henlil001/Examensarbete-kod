import { HockeyPlayerService } from './hockeyplayer.service';
import { HockeyPlayers } from './Entity/HockeyPlayers';
export declare class HockeyPlayerController {
    private readonly HockeyPlayerService;
    constructor(HockeyPlayerService: HockeyPlayerService);
    GetAllPlayersAsync(): Promise<HockeyPlayers[]>;
    SearhPlayerAsync(searchVal: any): Promise<HockeyPlayers[]>;
    AddPlayerAsync(Player: HockeyPlayers): Promise<string>;
    UpdatePlayerAsync(Player: HockeyPlayers): Promise<string>;
    DeletePlayerAsync(id: number): Promise<string>;
}
