"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var __param = (this && this.__param) || function (paramIndex, decorator) {
    return function (target, key) { decorator(target, key, paramIndex); }
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.HockeyPlayerService = void 0;
const common_1 = require("@nestjs/common");
const typeorm_1 = require("@nestjs/typeorm");
const HockeyPlayers_1 = require("./Entity/HockeyPlayers");
const typeorm_2 = require("typeorm");
let HockeyPlayerService = class HockeyPlayerService {
    HockeyPlayerRepository;
    constructor(HockeyPlayerRepository) {
        this.HockeyPlayerRepository = HockeyPlayerRepository;
    }
    async GetAllPlayersAsync() {
        return await this.HockeyPlayerRepository.find();
    }
    async SearhPlayerAsync(searchVal) {
        return await this.HockeyPlayerRepository.find({
            where: {
                fullName: (0, typeorm_2.ILike)(`%${searchVal}%`),
            },
            order: {
                club: 'ASC',
            }
        });
    }
    async AddPlayerAsync(Player) {
        await this.HockeyPlayerRepository.insert(Player);
    }
    async UpdatePlayerAsync(Player) {
        const PlayerToUpdate = await this.HockeyPlayerRepository.findOne(Player.id);
        if (PlayerToUpdate) {
            await this.HockeyPlayerRepository.update(Player.id, Player);
            return true;
        }
        else {
            return false;
        }
    }
    async DeletePlayerAsync(id) {
        const PlayerToDelete = await this.HockeyPlayerRepository.findOneBy({ id: id });
        if (PlayerToDelete) {
            await this.HockeyPlayerRepository.delete(id);
            return true;
        }
        else {
            return false;
        }
    }
};
exports.HockeyPlayerService = HockeyPlayerService;
exports.HockeyPlayerService = HockeyPlayerService = __decorate([
    (0, common_1.Injectable)(),
    __param(0, (0, typeorm_1.InjectRepository)(HockeyPlayers_1.HockeyPlayers)),
    __metadata("design:paramtypes", [typeorm_2.Repository])
], HockeyPlayerService);
//# sourceMappingURL=hockeyplayer.service.js.map