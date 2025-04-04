"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.AppModule = void 0;
const common_1 = require("@nestjs/common");
const typeorm_1 = require("@nestjs/typeorm");
const config_1 = require("@nestjs/config");
const hockeyplayer_controllers_1 = require("./hockeyplayer.controllers");
const hockeyplayer_service_1 = require("./hockeyplayer.service");
const HockeyPlayers_1 = require("./Entity/HockeyPlayers");
let AppModule = class AppModule {
};
exports.AppModule = AppModule;
exports.AppModule = AppModule = __decorate([
    (0, common_1.Module)({
        imports: [
            config_1.ConfigModule.forRoot(),
            typeorm_1.TypeOrmModule.forRoot({
                type: 'mssql',
                host: process.env.DB_HOST,
                port: 1433,
                username: process.env.DB_USER,
                password: process.env.DB_PASSWORD,
                database: process.env.DB_NAME,
                synchronize: false,
                logging: true,
                extra: {
                    trustServerCertificate: true,
                },
            }),
            typeorm_1.TypeOrmModule.forFeature([HockeyPlayers_1.HockeyPlayers])
        ],
        controllers: [hockeyplayer_controllers_1.HockeyPlayerController],
        providers: [hockeyplayer_service_1.HockeyPlayerService],
    })
], AppModule);
//# sourceMappingURL=app.module.js.map