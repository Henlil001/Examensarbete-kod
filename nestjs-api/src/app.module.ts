import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { ConfigModule } from '@nestjs/config';
import { HockeyPlayerController } from './hockeyplayer.controllers';
import { HockeyPlayerService } from './hockeyplayer.service';
import { HockeyPlayers } from './Entity/HockeyPlayers';
@Module({
  imports: [
    ConfigModule.forRoot(), 
    TypeOrmModule.forRoot({
      type: 'mssql',               // Använder Microsoft SQL Server
      host: process.env.DB_HOST,   // T.ex. 'localhost'
      port: 1433,                 // Standard MSSQL-port
      username: process.env.DB_USER, // Ditt användarnamn för SQL Server
      password: process.env.DB_PASSWORD, // Ditt lösenord
      database: process.env.DB_NAME, // Namnet på din databas
      synchronize: false,            // För att skapa tabellerna automatiskt, sätt till false i produktion
      logging: true,  
      extra: {
        trustServerCertificate: true,               // Sätt till true för att logga SQL-frågor
      },
    }),
    TypeOrmModule.forFeature([HockeyPlayers])
    
  ],
  controllers: [HockeyPlayerController],
  providers: [HockeyPlayerService],
})
export class AppModule {}
