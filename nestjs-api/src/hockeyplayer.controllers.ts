import { Controller, Get, Put, Delete, Post, Param, Body, BadRequestException } from '@nestjs/common';
import { HockeyPlayerService } from './hockeyplayer.service';
import { HockeyPlayers } from './Entity/HockeyPlayers';

@Controller('HockeyPlayer')
export class HockeyPlayerController{
    constructor(private readonly HockeyPlayerService: HockeyPlayerService){}
    @Get()
    async GetAllPlayersAsync(): Promise<HockeyPlayers[]>{
        return this.HockeyPlayerService.GetAllPlayersAsync();
    }

    @Get(':searchVal')
    async SearhPlayerAsync(@Param('SearchVal') searchVal): Promise<HockeyPlayers[]>{
        return this.HockeyPlayerService.SearhPlayerAsync(searchVal);
    }

    @Post()
    async AddPlayerAsync(Player: HockeyPlayers): Promise<string>{
        this.HockeyPlayerService.AddPlayerAsync(Player);
        return "Player Added";
    }
    @Put()
    async UpdatePlayerAsync(@Body()Player: HockeyPlayers): Promise<string>{
        await this.HockeyPlayerService.UpdatePlayerAsync(Player);
        return "Player Updated";
    }
    @Delete(':id')
    async DeletePlayerAsync(@Param('id') id: number): Promise<string>{
        const check: boolean = await this.HockeyPlayerService.DeletePlayerAsync(id);
        if(check){
            return `Player with ID: ${id} Deleted`;
        }
        throw new BadRequestException(`Player with ID: ${id} was not fond`); 
    }
}
