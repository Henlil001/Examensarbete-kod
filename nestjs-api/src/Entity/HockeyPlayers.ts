import { Entity, PrimaryGeneratedColumn, Column } from 'typeorm';

@Entity('HockeyPlayers')
export class HockeyPlayers {
  @PrimaryGeneratedColumn()
  id: number;

  @Column()
  fullName: string;

  @Column()
  heightInCm: number;

  @Column()
  weightInKg: number;

  @Column()
  club: string;

  @Column()
  position: string;

  @Column()
  age: number;
}