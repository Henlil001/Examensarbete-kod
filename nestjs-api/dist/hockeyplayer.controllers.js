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
exports.HockeyPlayerController = void 0;
const common_1 = require("@nestjs/common");
const hockeyplayer_service_1 = require("./hockeyplayer.service");
const HockeyPlayers_1 = require("./Entity/HockeyPlayers");
let HockeyPlayerController = class HockeyPlayerController {
    HockeyPlayerService;
    constructor(HockeyPlayerService) {
        this.HockeyPlayerService = HockeyPlayerService;
    }
    async GetAllPlayersAsync() {
        return this.HockeyPlayerService.GetAllPlayersAsync();
    }
    async SearhPlayerAsync(searchVal) {
        return this.HockeyPlayerService.SearhPlayerAsync(searchVal);
    }
    async AddPlayerAsync(Player) {
        this.HockeyPlayerService.AddPlayerAsync(Player);
        return "Player Added";
    }
    async UpdatePlayerAsync(Player) {
        await this.HockeyPlayerService.UpdatePlayerAsync(Player);
        return "Player Updated";
    }
    async DeletePlayerAsync(id) {
        const check = await this.HockeyPlayerService.DeletePlayerAsync(id);
        if (check) {
            return `Player with ID: ${id} Deleted`;
        }
        throw new common_1.BadRequestException(`Player with ID: ${id} was not fond`);
    }
};
exports.HockeyPlayerController = HockeyPlayerController;
__decorate([
    (0, common_1.Get)(),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", []),
    __metadata("design:returntype", Promise)
], HockeyPlayerController.prototype, "GetAllPlayersAsync", null);
__decorate([
    (0, common_1.Get)(':searchVal'),
    __param(0, (0, common_1.Param)('SearchVal')),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Object]),
    __metadata("design:returntype", Promise)
], HockeyPlayerController.prototype, "SearhPlayerAsync", null);
__decorate([
    (0, common_1.Post)(),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [HockeyPlayers_1.HockeyPlayers]),
    __metadata("design:returntype", Promise)
], HockeyPlayerController.prototype, "AddPlayerAsync", null);
__decorate([
    (0, common_1.Put)(),
    __param(0, (0, common_1.Body)()),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [HockeyPlayers_1.HockeyPlayers]),
    __metadata("design:returntype", Promise)
], HockeyPlayerController.prototype, "UpdatePlayerAsync", null);
__decorate([
    (0, common_1.Delete)(':id'),
    __param(0, (0, common_1.Param)('id')),
    __metadata("design:type", Function),
    __metadata("design:paramtypes", [Number]),
    __metadata("design:returntype", Promise)
], HockeyPlayerController.prototype, "DeletePlayerAsync", null);
exports.HockeyPlayerController = HockeyPlayerController = __decorate([
    (0, common_1.Controller)('HockeyPlayer'),
    __metadata("design:paramtypes", [hockeyplayer_service_1.HockeyPlayerService])
], HockeyPlayerController);
//# sourceMappingURL=hockeyplayer.controllers.js.map