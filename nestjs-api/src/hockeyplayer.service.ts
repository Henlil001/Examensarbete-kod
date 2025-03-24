import { Injectable } from "@nestjs/common";
import { InjectRepository } from '@nestjs/typeorm';
import { HockeyPlayers } from "./Entity/HockeyPlayers";
import { Repository, ILike } from 'typeorm';

@Injectable()
export class HockeyPlayerService{
    constructor(@InjectRepository(HockeyPlayers) private readonly HockeyPlayerRepository: Repository<HockeyPlayers>){}

    async GetAllPlayersAsync(): Promise<HockeyPlayers[]>{
        return await this.HockeyPlayerRepository.find();
    }
    async SearhPlayerAsync(searchVal : string): Promise<HockeyPlayers[]>{
        return await this.HockeyPlayerRepository.find({
            where: {
                fullName: ILike(`%${searchVal}%`),
            },
            order: {
                club: 'ASC', 
            }
        });
    }
    async AddPlayerAsync(Player:any){
        await this.HockeyPlayerRepository.insert(Player);
    }
    async UpdatePlayerAsync(Player: any) : Promise<boolean>{
        const PlayerToUpdate = await this.HockeyPlayerRepository.findOne(Player.id);
        if(PlayerToUpdate){
            await this.HockeyPlayerRepository.update(Player.id, Player);
            return true;
        }
        else{
            return false;
        }
    }
    async DeletePlayerAsync(id : number) : Promise<boolean>{
        const PlayerToDelete = await this.HockeyPlayerRepository.findOneBy({ id: id });
        if(PlayerToDelete){
            await this.HockeyPlayerRepository.delete(id);
            return true;
        }
        else{
            return false;
        }
    }
}