import { HockeyPlayers } from "./Entity/HockeyPlayers";
import { Repository } from 'typeorm';
export declare class HockeyPlayerService {
    private readonly HockeyPlayerRepository;
    constructor(HockeyPlayerRepository: Repository<HockeyPlayers>);
    GetAllPlayersAsync(): Promise<HockeyPlayers[]>;
    SearhPlayerAsync(searchVal: string): Promise<HockeyPlayers[]>;
    AddPlayerAsync(Player: any): Promise<void>;
    UpdatePlayerAsync(Player: any): Promise<boolean>;
    DeletePlayerAsync(id: number): Promise<boolean>;
}
